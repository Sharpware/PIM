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

        public void Add(Cliente cliente)
        {
            _modelDao.Clientes.Add(cliente);
            _modelDao.SaveChanges();
        }

        public void Remover(Cliente cliente)
        {
            _modelDao.Clientes.Remove(cliente);
            _modelDao.SaveChanges();
        }

        public Cliente BuscarPorId(int id)
        {
            return _modelDao.Clientes.Find(id);
        }
    }
}
