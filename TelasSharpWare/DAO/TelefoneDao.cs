using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class TelefoneDao
    {
        MySqlConnection _con;
        public TelefoneDao(MySqlConnection con)
        {
            _con = con;
        }

        public bool SalvarTelefoneCliente(Cliente cliente, long id)
        {
            try
            {
                bool resQuery = false;
                foreach (Telefone telefone in cliente.Telefones)
                {
                    string cmdInsertTelefone = @"INSERT INTO telefone_cliente
                                            (
                                            numero, 
                                            tipo_telefone,
                                            id_cliente)
                                            VALUES
                                            (
                                            @numero, 
                                            @tipo_telefone,
                                            @id_cliente
                                            )";
                    using (MySqlCommand cmd = new MySqlCommand(cmdInsertTelefone, _con))
                    {
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@numero", telefone.Numero);
                            cmd.Parameters.AddWithValue("@tipo_telefone", telefone.TipoTelefone.ToString());
                            cmd.Parameters.AddWithValue("@id_cliente", id);
                            resQuery = cmd.ExecuteNonQuery()>0; 
                    }
                }
                return resQuery;
            }
            catch(Exception erro)
            {
                throw new Exception("Ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        public List<Telefone> BuscarTelefonesCliente(long id)
        {
            try
            {
                MySqlDataReader reader = null;
                string cmdBuscaTelefone = @"select numero, tipo_telefone from telefone_cliente
                                            where id_cliente=@id";
                using (MySqlCommand cmd = new MySqlCommand(cmdBuscaTelefone, _con)) 
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", id);
                    reader = cmd.ExecuteReader();
                    List<Telefone> telefones = new List<Telefone>();
                    while(reader.Read())
                    {
                        Telefone telefone = new Telefone(reader.GetString("numero"), 
                        reader.GetString("tipo_telefone"));
                        telefones.Add(telefone);
                    }
                    return telefones;
                }
            }
            catch(Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }
    }
}
