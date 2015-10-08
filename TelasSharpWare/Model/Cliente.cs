using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Cliente 
    {
        private long _id;
        private String _nome;
        private String _cpf;
        private DateTime _dataNascimento;
        private String _email;
        private Status _status;
        private String _observacao;
        private Endereco _endereco;
        private Lazy<IList<Telefone>> _lazyTelefones;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {
                _cpf = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }

            set
            {
                _dataNascimento = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public Status Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string Observacao
        {
            get
            {
                return _observacao;
            }

            set
            {
                _observacao = value;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                _endereco = value;
            }
        }

        public Lazy<IList<Telefone>> LazyTelefones
        {
            get
            {
                return _lazyTelefones;
            }

            set
            {
                _lazyTelefones = value;
            }
        }
    }
}
