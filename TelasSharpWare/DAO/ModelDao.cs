using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelasSharpWare.DAO
{
    public class ModelDao
    {
        private string _str = @"server=localhost;database=sharpware;userid=root;password=";
        private MySqlConnection _con = null;

        public ModelDao()
        {

        }

<<<<<<< HEAD
        public virtual DbSet<Cliente> Clientes { get; set; }
        //public virtual DbSet<Funcionario> Funcionarios { get; set; }
        //public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        //public virtual DbSet<Venda> Vendas { get; set; }
        //public virtual DbSet<Produto> Produtos { get; set; }
        //public virtual DbSet<ItensVenda> ItensVendas { get; set; }
=======
        public MySqlConnection IniciarConexao()
        {
            try
            {
                _con = new MySqlConnection(_str);
                _con.Open();
            }
            catch (MySqlException err)
            {
                Console.WriteLine("Error: " + err.ToString());
            }
            return _con;
        }

        public void FinalizarConexao()
        {
            if (_con != null)
            {
                _con.Close();
            }
        }
>>>>>>> 2bb5c8ffa385b41d1f1b5f2bcd38906b489ea533

        ~ModelDao()
        {
<<<<<<< HEAD
            modelBuilder.Entity<Cliente>().Property(cliente => cliente.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
=======
            FinalizarConexao();
>>>>>>> 2bb5c8ffa385b41d1f1b5f2bcd38906b489ea533
        }
    }
}
