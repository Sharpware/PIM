using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.DAO;
using TelasSharpWare.Model;

namespace TelasSharpWare.Controller
{
    public class ClienteController
    {
        private Cliente _cliente;
        private ClienteDao _clienteDao;

        public ClienteController()
        {
            _clienteDao = new ClienteDao();
        }

        public void CadastrarCliente(Cliente cliente)
        {
            _clienteDao.Add(cliente);
        }
    }
}
