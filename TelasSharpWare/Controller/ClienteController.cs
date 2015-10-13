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

        public List<Cliente> PesquisarTodosClientes()
        {
            return _clienteDao.BuscarTodos();
        }

        public List<Cliente> PesquisarPorNome(string nome)
        {
            return _clienteDao.BuscarPorNome(nome);
        }

        public List<Cliente> PesquisarPorId(int id)
        {
            return _clienteDao.BuscarPorId(id);
        }

        public List<Cliente> PesquisarPorCPF(string cpf)
        {
            return _clienteDao.BuscarPorCPF(cpf);
        }
    }
}
