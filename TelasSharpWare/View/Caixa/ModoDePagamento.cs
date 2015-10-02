using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasSharpWare.View.Caixa;

namespace TelasSharpWare
{
    public partial class ModoDePagamento : Form
    {
        public ModoDePagamento()
        {
            InitializeComponent();
        }

        // Define the CS_DROPSHADOW constant
        private const int CS_DROPSHADOW = 0x00020000;

        // Override the CreateParams property
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        private void ModoDePagamento_Load(object sender, EventArgs e)
        {
            ModoLbl.Text = "";
        }

        private void botaoDinheiro1_Click(object sender, EventArgs e)
        {
            PagamentoDinheiro pagamentoDinheiro = new PagamentoDinheiro();
            pagamentoDinheiro.ShowDialog();
            
        }

        private void botaoDinheiro1_MouseEnter(object sender, EventArgs e)
        {
            ModoLbl.Text = "Dinheiro";
        }

        private void botaoDinheiro1_MouseLeave(object sender, EventArgs e)
        {
            ModoLbl.Text = "";
        }

        private void botaoCartao1_MouseEnter(object sender, EventArgs e)
        {
            ModoLbl.Text = "Cartão";
        }

        private void botaoCartao1_MouseLeave(object sender, EventArgs e)
        {
            ModoLbl.Text = "";
        }

        private void botaoCartao1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
