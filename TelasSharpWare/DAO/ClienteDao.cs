using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    public class ClienteDao
    {
        ModelDao modelDao = new ModelDao();

        public void AddCliente(Cliente cliente)
        {
            modelDao.Clientes.Add(cliente);
            modelDao.SaveChanges();
        }
    }
}
