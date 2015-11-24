using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    class RelatorioModel
    {
        private String cliente;

        public String Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        private String vendedor;

        public String Vendedor
        {
            get { return vendedor; }
            set { vendedor = value; }
        }
        private String produto;

        public String Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        private Int32 quantidade;

        public Int32 Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        private Double valorTotal;

        public Double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }
        private Int32 codigo;

        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
