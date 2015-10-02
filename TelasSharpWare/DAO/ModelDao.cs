namespace TelasSharpWare
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Model;

    public partial class ModelDao : DbContext
    {
        public ModelDao()
            : base("name=ModelDao")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Fornecedor> Fornecedores { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public virtual DbSet<ItensVenda> ItensVendas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
