using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;
using MySql.Data.MySqlClient;

namespace TelasSharpWare.DAO
{
    public class VendaDao
    {
        MySqlConnection _con;
        public VendaDao(MySqlConnection con)
        {
            _con = con;
        }

        public void SalvarVenda(Venda venda)
        {
            try
            {
                string cmdSalvarVenda = @"insert into venda (valor_total, tipo_venda, data_venda)
                                        values (@valor_total, @tipo_venda, @data_venda)";
                using (MySqlCommand cmd = new MySqlCommand(cmdSalvarVenda, _con))
                {
                    cmd.Prepare();
                    cmd.
                }
            }
        }
    }
}
