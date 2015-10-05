using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    public class VendaController
    {
        private Venda _venda;
        private VendaDao _vendaDao;

        public void AddProduto(Produto produto)
        {
            _venda.AddProduto(produto);
        }

        public void RemoverProduto(int posicao)
        {
            _venda.RemoverProduto(posicao);
        }

        public void ConcluirVenda(TipoVenda tipoVenda)
        {
            _venda.TipoVenda = tipoVenda;
            _vendaDao.AddVenda(_venda);
        }
    }
}
