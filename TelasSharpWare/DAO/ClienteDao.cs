﻿using MySql.Data.MySqlClient;
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
        private ModelDao modelDao;

        public ClienteDao()
        {
            modelDao = new ModelDao();
        }

        public void Add(Cliente cliente)
        {
            MySqlConnection con = modelDao.IniciarConexao();

            try
            {
                string cmdText = "INSERT INTO cliente (nome, cpf, dataNascimento, observacao, email) VALUES(@nome, @cpf, @dataNascimento, @observacao, @email)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
                cmd.Parameters.AddWithValue("@observacao", cliente.Observacao);
                cmd.Parameters.AddWithValue("@email", cliente.Email);

                cmd.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw new Exception("ocorreu o seguinte erro: " + erro.ToString());
            }
            finally
            {
                if (con != null)
                {
                    modelDao.FinalizarConexao();
                }
            }
        }

        public List<Cliente> BuscarTodos()
        {
            MySqlConnection con = null;
            MySqlDataReader reader = null;
            List<Cliente> clientes = new List<Cliente>();

            con = modelDao.IniciarConexao();
            string cmdText = "SELECT id, nome, cpf FROM cliente";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            reader = cmd.ExecuteReader();
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
            modelDao.FinalizarConexao();
            return clientes;
        }

        public List<Cliente> BuscarPorNome(string nome)
        {
            MySqlConnection con = null;
            MySqlDataReader reader = null;
            List<Cliente> clientes = null;
            con = modelDao.IniciarConexao();
            string cmdText = "SELECT id, nome, cpf FROM cliente WHERE nome=@nome";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
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
            modelDao.FinalizarConexao();
            return clientes;
        }

        public List<Cliente> BuscarPorId(int id)
        {
            MySqlConnection con = null;
            MySqlDataReader reader = null;
            List<Cliente> clientes = null;
            con = modelDao.IniciarConexao();
            string cmdText = "SELECT id, nome, cpf FROM cliente WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@id", id);
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
            modelDao.FinalizarConexao();
            return clientes;
        }

        public List<Cliente> BuscarPorCPF(string cpf)
        {
            MySqlConnection con = null;
            MySqlDataReader reader = null;
            List<Cliente> clientes = null;
            con = modelDao.IniciarConexao();
            string cmdText = "SELECT id, nome, cpf FROM cliente WHERE cpf=@cpf";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
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
            modelDao.FinalizarConexao();
            return clientes;
        }

        public void Inativacao(Cliente cliente)
        {
            MySqlConnection con = modelDao.IniciarConexao();
            MySqlDataReader reader = null;
            string cmdText = @"ALTER TABLE cliente MODIFY COLUNM";
        }
    }
}
