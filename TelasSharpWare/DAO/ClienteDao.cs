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
        ModelDao _modelDao;

        public ClienteDao()
        {
            _modelDao = new ModelDao();
            _modelDao.Database.CreateIfNotExists();
        }

        public void AddCliente(Cliente cliente)
        {
            _modelDao.Clientes.Add(cliente);
            _modelDao.SaveChanges();
            _modelDao.Dispose();
        }

        public void RemoverCliente(Cliente cliente)
        {
            _modelDao.Clientes.Remove(cliente);
            _modelDao.SaveChanges();
            _modelDao.Dispose();
        }

        public Cliente BuscarCliente(Cliente cliente)
        {
            return _modelDao.Clientes.Find(cliente.Id);
        }
    }
}
