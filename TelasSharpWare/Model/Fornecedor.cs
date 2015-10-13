using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Fornecedor
    {
        private long _id;
        private String _nomeFantasia;
        private String _razaoSocial;
        private String _cnpj;
        private String _observacao;
        private Endereco _endereco;
        private Situacao _fornecedor;
        private Lazy<IList<String>> _lazyEmails;
        private Lazy<IList<Produto>> _lazyProdutos;
        private Lazy<IList<Telefone>> _lazyTelefones;

        public Fornecedor()
        {
            _lazyEmails = new Lazy<IList<String>>(() => new List<String>());
            _lazyProdutos = new Lazy<IList<Produto>>(() => new List<Produto>());
            _lazyTelefones = new Lazy<IList<Telefone>>(() => new List<Telefone>());
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return _nomeFantasia;
            }
        }
        public Fornecedor SetNomeFantasia(String nomeFantasia)
        {
            _nomeFantasia = nomeFantasia;
            return this;
        }

        public string RazaoSocial
        {
            get
            {
                return _razaoSocial;
            }
        }
        public Fornecedor SetRazaoSocial(String razaoSocial)
        {
            _razaoSocial = razaoSocial;
            return this;
        }

        public string CNPJ
        {
            get
            {
                return _cnpj;
            }
        }
        public Fornecedor SetCNPJ(String cnpj)
        {
            _cnpj = cnpj;
            return this;
        }

        public string Observacao
        {
            get
            {
                return _observacao;
            }
        }
        public Fornecedor SetObservacao(String observacao)
        {
            _observacao = observacao;
            return this;
        }

        public Endereco Endereco
        {
            get
            {
                return _endereco;
            }
        }
        public Fornecedor SetEndereco(Endereco endereco)
        {
            _endereco = endereco;
            return this;
        }

        public Situacao Status
        {
            get
            {
                return _fornecedor;
            }
        }
        public Fornecedor SetStatus(Situacao status)
        {
            _fornecedor = status;
            return this;
        }

        public IReadOnlyCollection<String> Emails
        {
            get
            {
                return new ReadOnlyCollection<String>(_lazyEmails.Value);
            }
        }
        public Fornecedor AddEmail(String email)
        {
            _lazyEmails.Value.Add(email);
            return this;
        }

        public IReadOnlyCollection<Produto> Produtos
        {
            get
            {
                return new ReadOnlyCollection<Produto>(_lazyProdutos.Value);
            }
        }
        public Fornecedor AddProdutos(Produto produto)
        {
            _lazyProdutos.Value.Add(produto);
            return this;
        }

        public IReadOnlyCollection<Telefone> Telefones
        {
            get
            {
                return new ReadOnlyCollection<Telefone>(_lazyTelefones.Value);
            }
        }
        public Fornecedor AddTelefones(Telefone telefone)
        {
            _lazyTelefones.Value.Add(telefone);
            return this;
        }
    }
}
