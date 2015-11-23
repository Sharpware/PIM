using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RelatoriosSharpware.Controller;

namespace TelasSharpWare.View.Relatorio
{
    public partial class RelatorioVendaCliente : Form
    {
        public RelatorioVendaCliente()
        {
            InitializeComponent();
        }

        private void RelatorioVendaCliente_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fecharBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void sairBtn_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExibeRelatoriobtn_Click(object sender, EventArgs e)
        {
            if ((ParametroIdVendacbx.Text) != null)
            {
                RelatoriosSharpware.ExibirRelatoriofrm relatorio = new RelatoriosSharpware.ExibirRelatoriofrm();
                RelatoriosSharpware.Controller.RelatorioVendaClienteController relatorioControler = new RelatorioVendaClienteController();
                relatorioControler.BuscarVenda(Convert.ToInt32(ParametroIdVendacbx.Text));
                relatorio.ShowDialog();
            }
            else {
                MessageBox.Show("O campo com valor da venda não pode ser nulo favor informar o código da venda.",
             "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
