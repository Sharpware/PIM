using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public abstract class Pessoa<T>
    {
        public long _id;
        private String _nome;
        private String _cpf;
        private DateTime _dataNascimento;
        private String _email;
        private Situacao _situacao;
        private String _observacao;
        private Endereco _endereco;
        private Lazy<IList<Telefone>> _lazyTelefones;
        
        public Pessoa()
        {
            _lazyTelefones = new Lazy<IList<Telefone>>(() => new List<Telefone>());
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }
        public Pessoa<T> SetId(long id)
        {
            _id = id;
            return this;
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

        public Situacao Status
        {
            get
            {
                return _situacao;
            }
        }
        public Pessoa<T> SetStatus(Situacao status)
        {
            _situacao = status;
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
