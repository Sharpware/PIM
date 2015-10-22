using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    public class ProdutoDao
    {

        MySqlConnection _con;
        public ProdutoDao(MySqlConnection con)
        {
            _con = con;
        }

        public List<Produto> BuscarTodosProdutos()
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = new List<Produto>();

            string cmdText = @"SELECT id,
                                nome,
                                marca,
                                observacao,
                                tamanho,
                                preco_venda,
                                quantidade FROM produto";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Observacao = reader.GetString("observacao");
                        produto.Tamanho = reader.GetString("tamanho");
                        produto.PrecoVenda = reader.GetDouble("preco_venda");
                        produto.Quantidade = reader.GetInt32("quantidade");
                        produtos.Add(produto);
                    }
            }
            return produtos;   
        }

        public List<Produto> BuscarPorId(int id)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    observacao,
                                    tamanho,
                                    preco_venda,
                                    quantidade FROM produto WHERE id=@id";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@id", id);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Observacao = reader.GetString("observacao");
                        produto.Tamanho = reader.GetString("tamanho");
                        produto.PrecoVenda = reader.GetDouble("preco_venda");
                        produto.Quantidade = reader.GetInt32("quantidade");
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }

        public List<Produto> BuscarPorNome(string nome)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    observacao,
                                    tamanho,
                                    preco_venda,
                                    quantidade FROM produto WHERE nome=@nome";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", nome);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Observacao = reader.GetString("observacao");
                        produto.Tamanho = reader.GetString("tamanho");
                        produto.PrecoVenda = reader.GetDouble("preco_venda");
                        produto.Quantidade = reader.GetInt32("quantidade");
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }

        public List<Produto> BuscarPorMarca(string marca)
        {
            MySqlDataReader reader = null;
            List<Produto> produtos = null;
            string cmdText = @"SELECT id,
                                    nome,
                                    marca,
                                    observacao,
                                    tamanho,
                                    preco_venda,
                                    quantidade FROM produto WHERE marca=@marca";
            using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
            {
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@marca", marca);
                produtos = new List<Produto>();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto();
                        produto.Id = reader.GetInt64("id");
                        produto.Nome = reader.GetString("nome");
                        produto.Marca = reader.GetString("marca");
                        produto.Observacao = reader.GetString("observacao");
                        produto.Tamanho = reader.GetString("tamanho");
                        produto.PrecoVenda = reader.GetDouble("preco_venda");
                        produto.Quantidade = reader.GetInt32("quantidade");
                        produtos.Add(produto);
                    }
                }
            }
            return produtos;
        }
    }
}
