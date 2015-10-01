using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class ItensVenda
    {
        private long _id;
        private int _quantidade;
        private double _valorTotal;
        private Produto _produto;

        public ItensVenda(Produto produto, int quantidade)
        {
            _produto = produto;
            _quantidade = quantidade;
        }

        public long Id
        {
            get
            {
                return _id;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }
        }

        public double ValorTotal
        {
            get
            {
                return _valorTotal;
            }
        }

        public Produto Produto
        {
            get
            {
                return _produto;
            }
        }
    }
}
