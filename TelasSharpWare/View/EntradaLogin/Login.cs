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
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare
{
    public partial class Login : Form
    {
        Funcionario _funcionario = null;
        LoginController _loginController;

        public Login()
        {
            InitializeComponent();
            _funcionario = new Funcionario();
            _loginController = new LoginController();
        }

        private void botaoLogin1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.SetLoging(LoginTbx.Text)
                        .SetSenha(SenhaTbx.Text);
            _funcionario = _loginController.Logar(funcionario);
            if (_funcionario.Id > 0)
            {
                DialogResult = DialogResult.OK;
                LoginTbx.Text = "";
                SenhaTbx.Text = "";
            }
            else
            {
                DialogResult = DialogResult.Retry;
                LoginTbx.Text = "";
                SenhaTbx.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
