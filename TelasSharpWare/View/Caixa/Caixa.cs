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
        private VendaController _vendaController;
        private PesquisaProdutoController _produtoController;

        public Caixa()
        {
            InitializeComponent();
            _vendaController = new VendaController();
            _produtoController = new PesquisaProdutoController();
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
            Produto produto = _produtoController.PesquisaPorCodigoBarras(codigoBarrasProdutoTbx.Text);
            if (produto.Id > 0)
            {
                int index = vendaProdutosDgv.Rows.Add();
                DataGridViewRow linha = vendaProdutosDgv.Rows[index];
                linha.Cells["id"].Value = produto.Id;
                linha.Cells["marca"].Value = produto.Marca;
                linha.Cells["nome"].Value = produto.Nome;
                linha.Cells["descricao"].Value = produto.Observacao;
                linha.Cells["tamanho"].Value = produto.Tamanho;
                linha.Cells["valor"].Value = produto.PrecoVenda;
                linha.Cells["quantidade"].Value = produto.Quantidade;
                nomeProdutoTbx.Text = produto.Nome;
                descricaoProdutoTbx.Text = produto.Observacao;
                tamanhoTbx.Text = produto.Tamanho;
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
                nomeProdutoTbx.Text = "";
                descricaoProdutoTbx.Text = "";
                tamanhoTbx.Text = "";
            }
        }

        private void botaoFinalizarVenda2_Click(object sender, EventArgs e)
        {

        }

        private void botaoModoDePagamento1_Click(object sender, EventArgs e)
        {
            ModoDePagamento pagamento = new ModoDePagamento();
            pagamento.ShowDialog();
        }

        private void abrirVendaBtn_Click(object sender, EventArgs e)
        {
            _venda = _vendaController.IniciarVenda(new Cliente(), new Funcionario());
        }
    }
}
