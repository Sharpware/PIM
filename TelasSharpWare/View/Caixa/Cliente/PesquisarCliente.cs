﻿using System;
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
    public partial class PesquisarCliente : Form
    {
        private ClienteController _clienteController;
        public PesquisarCliente()
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

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            pesquisaClienteDgv.Rows.Clear();
            if(nomeTbx.Text != "" && nomeRb.Checked == true)
            {
                Cliente cliente = _clienteController.PesquisarPorNome(nomeTbx.Text);
                if (cliente.Id != 0)
                {
                    int index = pesquisaClienteDgv.Rows.Add();
                    DataGridViewRow linha = pesquisaClienteDgv.Rows[index];
                    linha.Cells["id"].Value = cliente.Id;
                    linha.Cells["nome"].Value = cliente.Nome;
                    linha.Cells["cpf"].Value = cliente.CPF;
                }
                else
                    MessageBox.Show("Cliente não encontrado");
            }



            if (nomeTbx.Text == "" &&
                idTbx.Text == "" &&
                cpfTbx.Text == "")
            {
                List<Cliente> clientes = _clienteController.PesquisarTodosClientes();
                foreach (Cliente cliente in clientes)
                {
                    int index = pesquisaClienteDgv.Rows.Add();
                    DataGridViewRow linha = pesquisaClienteDgv.Rows[index];
                    linha.Cells["id"].Value = cliente.Id;
                    linha.Cells["nome"].Value = cliente.Nome;
                    linha.Cells["cpf"].Value = cliente.CPF;
                }
            }
        }
    }
}
