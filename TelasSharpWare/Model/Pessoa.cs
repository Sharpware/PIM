using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public abstract class Pessoa
    {
        private long _id;
        private String _nome;
        private long _cpf;
        private DateTime _dataNascimento;
        private String _email;
        private Status _status;
        private String _observacao;
        private Endereco _endereco;
        private Lazy<IList<Telefone>> _lazyTelefones;
        
        public Pessoa(long id, String nome, long cpf, DateTime dataNascimento, 
                      String email, String observacao, Status status, Endereco endereco)
        {
            _id = id;
            _nome = nome;
            _cpf = cpf;
            _dataNascimento = dataNascimento;
            _email = email;
            _observacao = observacao;
            _status = status;
            _endereco = endereco;
            _lazyTelefones = new Lazy<IList<Telefone>>(() => new List<Telefone>());
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }

        public long Cpf
        {
            get
            {
                return _cpf;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }

        public string Observacao
        {
            get
            {
                return _observacao;
            }
        }

        public Status Status
        {
            get
            {
                return _status;
            }
        }

        public Endereco Endereco
        {
            get
            {
                return _endereco;
            }
        }

        public IReadOnlyCollection<Telefone> Telefones
        {
            get
            {
                return new ReadOnlyCollection<Telefone>(_lazyTelefones.Value);
            }
        }

    }
}
