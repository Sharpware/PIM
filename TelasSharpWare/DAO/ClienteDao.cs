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
        private ModelDao modelDao;

        public ClienteDao()
        {
            modelDao = new ModelDao();
        }

        public void Add(Cliente cliente)
        {
            MySqlConnection con = modelDao.IniciarConexao();

            string cmdText = "INSERT INTO cliente (nome, cpf, dataNascimento, observacao, email) VALUES(@nome, @cpf, @dataNascimento, @observacao, @email)";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            cmd.Prepare();
            cmd.Parameters.AddWithValue("@nome", cliente.Nome);
            cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
            cmd.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
            cmd.Parameters.AddWithValue("@observacao", cliente.Observacao);
            cmd.Parameters.AddWithValue("@email", cliente.Email);

            modelDao.FinalizarConexao();
        }

        public void Remover(Cliente cliente)
        {
        }
    }
}
