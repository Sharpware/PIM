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
        public long Id { get; set; }
        private DateTime _data;
        private double _valorTotal;
        private Cliente _cliente;
        private Funcionario _funcionario;
        private TipoVenda tipoVenda;
        private List<ItemVenda> _itensVenda;

        public Venda(Cliente cliente, Funcionario funcionario)
        {
            _cliente = cliente;
            Funcionario = funcionario;
            _data = DateTime.Now;
            
        }

        public void AddItem(ItemVenda itensVenda)
        {
            ItemVenda itemVenda = new ItemVenda(itensVenda.Produto, itensVenda.Quantidade);
            ItensVenda.Add(itemVenda);
            _valorTotal += itemVenda.ValorTotal;
        }

        public void RemoverProduto(int posicao)
        {
            _valorTotal -= ItensVenda[posicao].ValorTotal;
            ItensVenda.RemoveAt(posicao);
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

        public Funcionario Funcionario
        {
            get
            {
                return _funcionario;
            }

            set
            {
                _funcionario = value;
            }
        }

        public List<ItemVenda> ItensVenda
        {
            get
            {
                return _itensVenda;
            }

            set
            {
                _itensVenda = value;
            }
        }
    }
}
