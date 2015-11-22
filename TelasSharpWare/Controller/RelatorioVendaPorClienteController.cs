using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    public class RelatorioVendaPorClienteController
    {
        RelatorioVendaClienteDao _relatorioVendaClienteDao;

        public RelatorioVendaPorClienteController()
        {
            var con = ConnectionFactory.GetConnection();
            _relatorioVendaClienteDao = new RelatorioVendaClienteDao(con);
        }

        public void BuscarVenda(int id)
        {
            _relatorioVendaClienteDao.BuscarVenda(id);
            _relatorioVendaClienteDao.BuscarListaItensProduto(id);
        }
        
    }
}
