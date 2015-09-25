using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.Model
{
    public class Produto
    {
        private long id;
        private String nome;
        private String marca;
        private int quantidade;
        private String tamanho;
        private long codigoBarras;
        private double precoCusto;
        private double precoVenda;
        private String observacao;
        private TipoProduto tipoFuncionario;
        private Status status;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public string Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        public long CodigoBarras
        {
            get
            {
                return codigoBarras;
            }

            set
            {
                codigoBarras = value;
            }
        }

        public double PrecoCusto
        {
            get
            {
                return precoCusto;
            }

            set
            {
                precoCusto = value;
            }
        }

        public double PrecoVenda
        {
            get
            {
                return precoVenda;
            }

            set
            {
                precoVenda = value;
            }
        }

        public string Observacao
        {
            get
            {
                return observacao;
            }

            set
            {
                observacao = value;
            }
        }

        public TipoProduto TipoFuncionario
        {
            get
            {
                return tipoFuncionario;
            }

            set
            {
                tipoFuncionario = value;
            }
        }

        public Status Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
