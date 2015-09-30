﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    public class VendaController
    {
        private Venda _venda;

        public VendaController(Venda venda)
        {
            _venda = venda;
        }

        public void AddProduto(Produto produto)
        {
            _venda.AddProduto(produto);
        }

        public void AddQtdProduto(Produto produto, int quantidade)
        {
            _venda.AddQtdProduto(produto, quantidade);
        }

        public void RmvProduto(int posicao)
        {
            _venda.RmvProduto(posicao);
        }

        public void ConcluirVenda(TipoVenda tipoVenda)
        {
            _venda.TipoVenda = tipoVenda;
            //Salvar no banco de dados
        }
    }
}