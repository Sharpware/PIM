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
        ModelDao modelDao = new ModelDao();

        public Produto BuscarProduto(int id)
        {
            return modelDao.Produtos.Find(id);
        }
    }
}
