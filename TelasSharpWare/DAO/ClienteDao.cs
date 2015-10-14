using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    public class ClienteDao
    {
        MySqlConnection _con = null;

        public ClienteDao(MySqlConnection con)
        {
            _con = con;
        }

        public bool SalvarCliente(Cliente cliente)
        {
            try
            {
                string cmdInsertCliente = @"INSERT INTO cliente
                                            (nome, 
                                            cpf, 
                                            data_nascimento, 
                                            observacao,
                                            situacao, 
                                            email,
                                            logradouro,
                                            numero,
                                            complemento,
                                            cep,
                                            bairro,
                                            uf,
                                            cidade)
                                            VALUES
                                            (@nome, 
                                            @cpf, 
                                            @data_nascimento, 
                                            @observacao,
                                            @situacao, 
                                            @email,
                                            @logradouro,
                                            @numero,
                                            @complemento,
                                            @cep,
                                            @bairro,
                                            @uf,
                                            @cidade)";
                using (var cmd = new MySqlCommand(cmdInsertCliente, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                    cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                    cmd.Parameters.AddWithValue("@data_nascimento", cliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@observacao", cliente.Observacao);
                    cmd.Parameters.AddWithValue("@situacao", cliente._Situacao.ToString());
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@logradouro", cliente.Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", cliente.Endereco.Numero);
                    cmd.Parameters.AddWithValue("@complemento", cliente.Endereco.Complemento);
                    cmd.Parameters.AddWithValue("@cep", cliente.Endereco.Cep);
                    cmd.Parameters.AddWithValue("@bairro", cliente.Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@uf", cliente.Endereco.Uf);
                    cmd.Parameters.AddWithValue("@cidade", cliente.Endereco.Cidade);
                    bool resQueryEndereco = cmd.ExecuteNonQuery() > 0;
                    long lastId = cmd.LastInsertedId;
                    TelefoneDao telefoneDao = new TelefoneDao(_con);
                    telefoneDao.SalvarTelefoneCliente(cliente, lastId);
                    return resQueryEndereco;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("ocorreu o seguinte erro: " + erro.ToString());
            }
        }

        public List<Cliente> BuscarTodos()
        {
            MySqlDataReader reader = null;
            List<Cliente> clientes = new List<Cliente>();
            string cmdText = "SELECT id, nome, cpf, situacao FROM cliente";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.SetId(reader.GetInt64("id"))
                        .SetNome(reader.GetString("nome"))
                        .SetCPF(reader.GetString("cpf"))
                        .SetSituacao(reader.GetString("situacao"));
                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }
        }

        public List<Cliente> BuscarPorNome(string nome)
        {
            MySqlDataReader reader = null;
            List<Cliente> clientes = null;
            string cmdText = "SELECT id, nome, cpf FROM cliente WHERE nome=@nome";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", nome);
                reader = cmd.ExecuteReader();
                clientes = new List<Cliente>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.SetId(reader.GetInt64("id"))
                        .SetNome(reader.GetString("nome"))
                        .SetCPF(reader.GetString("cpf"));
                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }
        }

        public Cliente BuscarPorId(int id)
        {
            MySqlDataReader reader = null;
            Cliente cliente = null;
            string cmdText = @"SELECT id, nome, 
                                            cpf, 
                                            data_nascimento, 
                                            observacao,
                                            situacao, 
                                            email,
                                            logradouro,
                                            numero,
                                            complemento,
                                            cep,
                                            bairro,
                                            uf,
                                            cidade FROM cliente WHERE id=@id";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
                reader = cmd.ExecuteReader();
                cliente = new Cliente();
                while (reader.Read())
                {
                    cliente.SetId(reader.GetInt64("id"))
                    .SetNome(reader.GetString("nome"))
                    .SetEmail(reader.GetString("email"))
                    .SetCPF(reader.GetString("cpf"))
                    .SetDataNascimento(reader.GetDateTime("data_nascimento"))
                    .SetObservacao(reader.GetString("observacao"))
                    .SetSituacao(reader.GetString("situacao"))
                    .SetEndereco(new Endereco()
                    .SetLogradouro(reader.GetString("logradouro"))
                    .SetNumero(reader.GetString("numero"))
                    .SetComplemento(reader.GetString("complemento"))
                    .SetCep(reader.GetString("cep"))
                    .SetBairro(reader.GetString("bairro"))
                    .SetUf(reader.GetString("uf"))
                    .SetCidade(reader.GetString("cidade")));
                }
                return cliente;
            }
        }

        public List<Cliente> BuscarPorCPF(string cpf)
        {
            MySqlDataReader reader = null;
            List<Cliente> clientes = null;
            string cmdText = "SELECT id, nome, cpf FROM cliente WHERE cpf=@cpf";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@cpf", cpf);
                reader = cmd.ExecuteReader();
                clientes = new List<Cliente>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.SetId(reader.GetInt64("id"))
                        .SetNome(reader.GetString("nome"))
                        .SetCPF(reader.GetString("cpf"));
                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }
        }

        /*public void Inativacao(Cliente cliente)
        {
            MySqlDataReader reader = null;
            string cmdText = @"ALTER TABLE cliente MODIFY COLUNM";
        }*/
    }
}
