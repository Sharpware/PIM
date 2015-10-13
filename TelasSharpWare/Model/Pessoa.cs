using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public abstract class Pessoa<T>
    {
        public long Id { get; set; }
        private String _nome;
        private String _cpf;
        private DateTime _dataNascimento;
        private String _email;
        private Status _status;
        private String _observacao;
        private Endereco _endereco;
        private Lazy<IList<Telefone>> _lazyTelefones;
        
        public Pessoa()
        {
            _lazyTelefones = new Lazy<IList<Telefone>>(() => new List<Telefone>());
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
        }
        public Pessoa<T> SetNome(String nome)
        {
            _nome = nome;
            return this;
        }

        public String CPF
        {
            get
            {
                return _cpf;
            }
        }
        public Pessoa<T> SetCPF(String cpf)
        {
            _cpf = cpf;
            return this;
        }

        public DateTime DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
        }
        public Pessoa<T> SetDataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
            return this;
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }
        public Pessoa<T> SetEmail(String email)
        {
            _email = email;
            return this;
        }

        public String Observacao
        {
            get
            {
                return _observacao;
            }
        }
        public Pessoa<T> SetObservacao(String observacao)
        {
            _observacao = observacao;
            return this;
        }

        public Status Status
        {
            get
            {
                return _status;
            }
        }
        public Pessoa<T> SetStatus(Status status)
        {
            _status = status;
            return this;
        }

        public Endereco Endereco
        {
            get
            {
                return _endereco;
            }
        }
        public Pessoa<T> SetEndereco(Endereco endereco)
        {
            _endereco = endereco;
            return this;
        }

        public virtual IReadOnlyCollection<Telefone> Telefones
        {
            get
            {
                return new ReadOnlyCollection<Telefone>(_lazyTelefones.Value);
            }
        }
        public Pessoa<T> AddTelefone(Telefone telefone)
        {
            _lazyTelefones.Value.Add(telefone);
            return this;
        }
    }
}
