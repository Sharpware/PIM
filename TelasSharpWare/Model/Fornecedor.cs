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
        private String _email;
        private String _observacao;
        private Endereco _endereco;
        private Status _status;
        private Lazy<IList<Produto>> _lazyProdutos;
        private Lazy<IList<Telefone>> _lazyTelefones;

        public Fornecedor(long id, String nomeFantasia, String razaoSocial, long cnpj,
                         String email, String observacao, Endereco endereco, Status status)
        {
            _id = id;
            _nomeFantasia = nomeFantasia;
            _razaoSocial = razaoSocial;
            _cnpj = cnpj;
            _email = email;
            _observacao = observacao;
            _endereco = endereco;
            _status = status;
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

        public string RazaoSocial
        {
            get
            {
                return _razaoSocial;
            }
        }

        public long Cnpj
        {
            get
            {
                return _cnpj;
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

        public Endereco Endereco
        {
            get
            {
                return _endereco;
            }
        }

        public Status Status
        {
            get
            {
                return _status;
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
