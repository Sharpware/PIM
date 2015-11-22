using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class RelatorioVendaClienteDao
    {
        private MySqlConnection _con;

        public RelatorioVendaClienteDao (MySqlConnection con)
        {
            _con = con;
        }

        public RelatorioVendaCliente BuscarPorVenda(Int32 idVenda)
        {
            try
            {
                MySqlDataReader reader = null;
                RelatorioVendaCliente relatorioVendaCliente;
                string cmdBuscarVenda = @"SELECT
                                          ven.id,
                                          ven.data_venda,
                                          ven.valor_total,
                                          ven.tipo_venda,
                                          cli.nome,
                                          cli.email,
                                          cli.cpf,
                                          fun.nome
                                          FROM venda ven
                                          INNER JOIN cliente cli 
                                          ON cli.id = ven.id_cliente
                                          INNER JOIN funcionario fun
                                          ON fun.id = ven.id_funcionario
                                          WHERE ven.id = @idVenda";

                using (MySqlCommand cmd = new MySqlCommand(cmdBuscarVenda, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@idVenda", idVenda);
                    reader = cmd.ExecuteReader();
                    relatorioVendaCliente = new RelatorioVendaCliente();
                    while (reader.Read())
                    {
                        //funcionario.SetId(reader.GetInt32("id"));
                        /*
                        private string nomeCliente;
                        private string cpfCliente;
                        private string emailCliente;
                        private DateTime dataVenda;
                        private Double valorVenda;
                        private string tipoVenda;
                        private string nomeFuncionario;*/
                        relatorioVendaCliente.IdVenda(reader.GetInt32("ven.id"));
                        relatorioVendaCliente.DataVenda(reader.GetDateTime("ven.data_venda"));
                      /*  relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.(""));
                        relatorioVendaCliente.(reader.("")); */

                    }
                    return relatorioVendaCliente;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }

    }
}
