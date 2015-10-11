﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    class PesquisaProdutoController
    {
        Produto _produto;
        ProdutoDao _produtoDao;

        public PesquisaProdutoController()
        {
            _produtoDao = new ProdutoDao();
        }

        public List<Produto> PesquisarTodos()
        {
            return _produtoDao.BuscarTodosProdutos();
        }

        public List<Produto> PesquisarPorId(int id)
        {
            return _produtoDao.BuscarPorId(id);
        }

        /*public List<Produto> PesquisarPorTipo(string tipo)
        {
            return _produtoDao.BuscarPorTpo(tipo);
        }*/

        public List<Produto> PesquisarPorNome(string nome)
        {
            return _produtoDao.BuscarPorNome(nome);
        }

        public List<Produto> PesquisarPorMarca(string marca)
        {
            return _produtoDao.BuscarPorMarca(marca);
        }
    }
}
