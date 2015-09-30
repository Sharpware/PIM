using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasSharpWare.Controller;
using TelasSharpWare.Model;

namespace TelasSharpWare
{
    public partial class Caixa : Form
    {
        private Venda _venda;
        private Cliente _cliente;
        private Funcionario _funcionario;
        private Produto _produto;
        private VendaController vendaController;

        public Caixa()
        {
            InitializeComponent();
            vendaController = new VendaController();
        }

        private void botaoFinalizarVenda2_Click(object sender, EventArgs e)
        {
            ModoDePagamento pagamento = new ModoDePagamento();
            pagamento.ShowDialog();
        }

        private void botaoAdicionarClienteCaixa1_Click(object sender, EventArgs e)
        {
            PesquisarCliente pesquisarCliente = new PesquisarCliente();
            pesquisarCliente.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atalhosBtn_Click(object sender, EventArgs e)
        {
            if (atalhosPnl.Visible == false)
            {
                atalhosPnl.Visible = true;
            }
            else
                atalhosPnl.Visible = false;
        }

        private void adicionarProdutoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
