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
        private TelefoneDao _telefoneDao;
        private ConnectionManager _connectionManager;

        public ClienteController()
        {
            var con = ConnectionFactory.GetConnection();
            _connectionManager = new ConnectionManager(con);
            _clienteDao = new ClienteDao(con);
        }

        public bool CadastrarCliente(Cliente cliente)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.SalvarCliente(cliente);
            }
        }

        public List<Cliente> PesquisarTodosClientes()
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.BuscarTodos();
            }
        }

        public List<Cliente> PesquisarPorNome(string nome)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.BuscarPorNome(nome);
            }
        }

        public Cliente PesquisarPorId(int id)
        {
            using (_connectionManager.Open())
            {
                Cliente cliente = _clienteDao.BuscarPorId(id);
                foreach(Telefone telefone in _telefoneDao.BuscarTelefonesCliente(id))
                {
                    cliente.AddTelefone(telefone);
                }
                return cliente;
            }
        }

        public List<Cliente> PesquisarPorCPF(string cpf)
        {
            using (_connectionManager.Open())
            {
                return _clienteDao.BuscarPorCPF(cpf);
            }
        }
    }
}
