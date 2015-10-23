using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;
using MySql.Data.MySqlClient;

namespace TelasSharpWare.Controller
{
    public class VendaController
    {
        private Venda _venda;
        private VendaDao _vendaDao;
        private ConnectionManager _connectionManager;

        public Venda IniciarVenda(Cliente cliente, Funcionario funcionario)
        {
            var con = ConnectionFactory.GetConnection();
            _vendaDao = new VendaDao(con);
            _connectionManager = new ConnectionManager(con);
            return _venda = new Venda(cliente, funcionario);
        }

        public Venda FinalizarVenda()
        {
            return _venda = null;
        }

        public void SalvarVenda()
        {
            using (_connectionManager.Open())
            {
                _vendaDao.SalvarVenda(_venda);
            }
        }

        public void AddItem(ItemVenda itemVenda)
        {
            _venda.AddItem(itemVenda);
        }

        public void RemoverProduto(int posicao)
        {
            _venda.RemoverProduto(posicao);
        }

        /*public void ConcluirVenda(TipoVenda tipoVenda)
        {
            _venda.TipoVenda = tipoVenda;
            _vendaDao.Add(_venda);
        }*/
    }
}
