using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Funcionario : Pessoa
    {
        private String _login;
        private String _senha;
        private TipoFuncionario _tipoFuncionario;

        public Funcionario(long id, String nome, long cpf, DateTime dataNascimento,
                        String observacao, Status status, Endereco endereco,
                        String login, String senha, TipoFuncionario tipoFuncionario) :
            base(id, nome, cpf, dataNascimento, observacao, status, endereco)
        {
            _login = login;
            _senha = senha;
            _tipoFuncionario = tipoFuncionario;
        }

        public string Login
        {
            get
            {
                return _login;
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }
        }

        public TipoFuncionario TipoFuncionario
        {
            get
            {
                return _tipoFuncionario;
            }
        }
    }
}
