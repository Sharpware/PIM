using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.DAO
{
    public class ModelDao
    {
        private string _str = @"server=localhost;database=sharpware;userid=root;password=admin";
        private MySqlConnection _con = null;

        public ModelDao()
        {

        }

        public MySqlConnection IniciarConexao()
        {
            try
            {
                _con = new MySqlConnection(_str);
                _con.Open();
            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            return _con;
        }

        public void FinalizarConexao()
        {
            if (_con != null)
            {
                _con.Close();
            }
        }
    }
}
