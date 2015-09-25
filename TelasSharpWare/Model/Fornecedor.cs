using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Fornecedor
    {
        private long id;
        private String nomeFantasia;
        private String razaoSocial;
        private long cnpj;
        private String emailPrimario;
        private String emailSecundario;
        private String telefonePrimario;
        private String telefoneSecundario;
        private String telefoneTerceario;
        private String observacao;
        private Endereco endereco;
        private Status status;
        private List<Produto> produtos;

        public Fornecedor()
        {
            produtos = new List<Produto>();
        }

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

        public string NomeFantasia
        {
            get
            {
                return nomeFantasia;
            }

            set
            {
                nomeFantasia = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return razaoSocial;
            }

            set
            {
                razaoSocial = value;
            }
        }

        public long Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string EmailPrimario
        {
            get
            {
                return emailPrimario;
            }

            set
            {
                emailPrimario = value;
            }
        }

        public string EmailSecundario
        {
            get
            {
                return emailSecundario;
            }

            set
            {
                emailSecundario = value;
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

        public string TelefoneTerceario
        {
            get
            {
                return telefoneTerceario;
            }

            set
            {
                telefoneTerceario = value;
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

        public Endereco Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public Status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
