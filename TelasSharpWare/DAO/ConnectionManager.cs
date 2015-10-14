using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.DAO 
{
    public class ConnectionManager : IDisposable
    {
        private readonly MySqlConnection _con;

        public ConnectionManager(MySqlConnection con)
        {
            if(con == null)
            {
                throw new NullReferenceException("O objeto não pode ser nulo (Problema de conexão) "); 
            }
            _con = con;
        }

        public MySqlConnection Open()
        {
            _con.Open();
            return _con;
        }

        public void Close()
        {
            if (_con != null)
            {
                _con.Close();
            }
        }

        public void Dispose()
        {
            Close();
        }
    }
}
