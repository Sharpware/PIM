using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class FuncionarioDao
    {
        private MySqlConnection _con;

        public FuncionarioDao(MySqlConnection con)
        {
            _con = con;
        }

        public List<Funcionario> BuscarFuncionarios()
        {
            try
            {
                MySqlDataReader reader = null;
                List<Funcionario> funcionarios;
                string cmdBuscarNomeFuncionario = @"select nome from funcionario";

                using (MySqlCommand cmd = new MySqlCommand(cmdBuscarNomeFuncionario, _con))
                {
                    reader = cmd.ExecuteReader();
                    funcionarios = new List<Funcionario>();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Funcionario funcionario = new Funcionario();
                            funcionario.SetNome(reader.GetString("nome"));
                            funcionarios.Add(funcionario);
                        }
                    }
                    return funcionarios;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }

        public Funcionario BuscarPorNome(string nome)
        {
            try
            {
                MySqlDataReader reader = null;
                Funcionario funcionario;
                string cmdBuscarNomeFuncionario = @"select id, nome from funcionario where nome=@nome";

                using (MySqlCommand cmd = new MySqlCommand(cmdBuscarNomeFuncionario, _con))
                {
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nome", nome);
                    reader = cmd.ExecuteReader();
                    funcionario = new Funcionario();
                    while (reader.Read())
                    {
                        funcionario.SetId(reader.GetInt32("id"));
                        funcionario.SetNome(reader.GetString("nome"));
                    }
                    return funcionario;
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.ToString());
            }
        }
    }
}
