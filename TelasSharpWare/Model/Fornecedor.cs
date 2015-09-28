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
        private long _cnpj;
        private String _observacao;
        private Endereco _endereco;
        private Status _status;
        private Lazy<IList<Produto>> _lazyProdutos;
        private Lazy<IList<Telefone>> _lazyTelefones;

        public Fornecedor()
        {
            _lazyProdutos = new Lazy<IList<Produto>>(() => new List<Produto>());
            _lazyTelefones = new Lazy<IList<Telefone>>(() => new List<Telefone>());
        }

        public long Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string NomeFantasia
        {
            get
            {
                return _nomeFantasia;
            }

            set
            {
                _nomeFantasia = value;
            }
        }

        public string RazaoSocial
        {
            get
            {
                return _razaoSocial;
            }

            set
            {
                _razaoSocial = value;
            }
        }

        public long Cnpj
        {
            get
            {
                return _cnpj;
            }

            set
            {
                _cnpj = value;
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

        public IReadOnlyCollection<Produto> Produtos
        {
            get
            {
                return new ReadOnlyCollection<Produto>(_lazyProdutos.Value);
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
