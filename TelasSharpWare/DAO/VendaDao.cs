﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    public class VendaDao
    {
        private ModelDao _modelDao;

        public VendaDao()
        {
            _modelDao = new ModelDao();
        }

        /*public void Add(Venda venda)
        {
            _modelDao.Vendas.Add(venda);
            _modelDao.SaveChanges();
            _modelDao.Dispose();
        }*/
    }
}
