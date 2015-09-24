using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public abstract class Pessoa
    {
        private long id;
        private String nome;
        private long cpf;
        private DateTime dataNascimento;
        private String telefonePrimario;
        private String telefoneSecundario;
        private String celular;
        private String observacao;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public long Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public string TelefonePrimario
        {
            get
            {
                return telefonePrimario;
            }

            set
            {
                telefonePrimario = value;
            }
        }

        public string TelefoneSecundario
        {
            get
            {
                return telefoneSecundario;
            }

            set
            {
                telefoneSecundario = value;
            }
        }

        public string Celular
        {
            get
            {
                return celular;
            }

            set
            {
                celular = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }
    }
}
