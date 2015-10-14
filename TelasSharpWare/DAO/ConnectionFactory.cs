using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.DAO
{
    public class ConnectionFactory
    {
        private const string _str = @"server=localhost;database=sharpware;userid=root;password=admin";

        private ConnectionFactory()
        { }

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_str);
        }
    }
}
