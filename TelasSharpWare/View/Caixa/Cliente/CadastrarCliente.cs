using System;
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
    public partial class CadastrarCliente : Form
    {
        ClienteController _clienteController;
        public CadastrarCliente()
        {
            InitializeComponent();
            _clienteController = new ClienteController();
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


        private void botaoCancelarCad1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }

        private void botaoCadCliente1_Click(object sender, System.EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.SetNome(nomeTbx.Text)
            .SetEmail(emailTbx.Text)
            .SetCPF(cpfTbx.Text)
            .SetDataNascimento(Convert.ToDateTime(dataNascimentoTbx.Text))
            .SetObservacao(observacaoTbx.Text);

            _clienteController.CadastrarCliente(cliente);
            MessageBox.Show("Filha da puta cadastrado");
        }

        private void botaoSair1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


    }
}

