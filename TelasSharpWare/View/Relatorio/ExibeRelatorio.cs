using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasSharpWare.Model;
using TelasSharpWare.DAO;
using TelasSharpWare.Controller;

namespace TelasSharpWare.View.Relatorio
{
    public partial class ExibeRelatorio : Form
    {
        public ExibeRelatorio()
        {
            InitializeComponent();
        }

        private void ExibeRelatorio_Load(object sender, EventArgs e)
        {
            RelatorioVendaPorClienteController controller = new RelatorioVendaPorClienteController();
            controller.BuscarVenda(6);
        }
    }
}
