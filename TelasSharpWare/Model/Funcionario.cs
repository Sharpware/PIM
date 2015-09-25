﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Funcionario : Pessoa
    {
        private String login;
        private String senha;
        private TipoFuncionario tipoFuncionario;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public TipoFuncionario TipoFuncionario
        {
            get
            {
                return tipoFuncionario;
            }

            set
            {
                tipoFuncionario = value;
            }
        }
    }
}
