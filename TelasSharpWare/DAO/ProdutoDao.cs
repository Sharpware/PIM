using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    public class ProdutoDao
    {
        ModelDao _modelDao;

        public ProdutoDao()
        {
            _modelDao = new ModelDao();
        }

        public Produto BuscarProduto(Produto produto)
        {
            return _modelDao.Produtos.Find(produto.Id);
        }
    }
}
