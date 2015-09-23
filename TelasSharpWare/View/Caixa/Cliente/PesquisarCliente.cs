using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasSharpWare
{
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
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


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botaoCadCliente1_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastroCliente = new CadastrarCliente();
            cadastroCliente.Show();
            this.Close();
        }

        private void botaoSair1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoInativarCliente1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inativar o cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }

        private void botaoEditarCliente1_Click(object sender, EventArgs e)
        {
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.Show();
        }


    }
}
