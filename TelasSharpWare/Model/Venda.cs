using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Venda
    {
        private long _id;
        private DateTime _data;
        private double _valorTotal;
        private Cliente _cliente;
        private Funcionario _funcionario;
        private TipoVenda tipoVenda;
        private Lazy<IList<Produto>> _lazyProdutos;

        public Venda(Cliente cliente, Funcionario funcionario)
        {
            _cliente = cliente;
            _funcionario = funcionario;
            _data = DateTime.Now;
            _lazyProdutos = new Lazy<IList<Produto>>(() => new List<Produto>());
        }

        public void AddProduto(Produto produto)
        {
            _lazyProdutos.Value.Add(produto);
            _valorTotal += produto.PrecoVenda;
        }

        public void RmvProduto(int posicao)
        {
           _valorTotal -= _lazyProdutos.Value[posicao].PrecoVenda;
            _lazyProdutos.Value.RemoveAt(posicao);
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
        }

        public double ValorTotal
        {
            get
            {
                return _valorTotal;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
        }

        public IReadOnlyCollection<Produto> Produtos
        {
            get
            {
                return new ReadOnlyCollection<Produto>(_lazyProdutos.Value);
            }
        }

        public TipoVenda TipoVenda
        {
            get
            {
                return tipoVenda;
            }

            set
            {
                tipoVenda = value;
            }
        }
    }
}
