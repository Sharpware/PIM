using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelasSharpWare.DAO;

namespace TelasSharpWare.View.Relatorio
{
    public partial class ExibirRelatoriofrm : Form
    {
        public ExibirRelatoriofrm()
        {
            InitializeComponent();
        }

        private void ExibirRelatoriofrm_Load(object sender, EventArgs e)
        {
            var con = ConnectionFactory.GetConnection();
            RelatorioDao relatorioDao = new RelatorioDao(con);
            relatorioDao.PreencherRelatorio(1);
            this.reportViewer1.RefreshReport();
        }
    }
}
