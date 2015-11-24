using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelasSharpWare.Model;

namespace TelasSharpWare.DAO
{
    class RelatorioDao
    {
         MySqlConnection _con;
         public RelatorioDao(MySqlConnection con)
        {
            _con = con;
        }

         public List<RelatorioModel> PreencherRelatorio(int codCliente )
         {
             MySqlDataReader reader = null;
             List<RelatorioModel> _relatorioModel = new List<RelatorioModel>();
             string cmdText = @"SELECT 
                               cli.nome as 'Cliente',
                               fun.nome as 'Vendedor',
                               prod.nome as 'Produto',
                               itnvend.quantidade as 'Quantidade',
                               itnvend.valor_total as 'ValorTotal',
                               vend.id as 'Código',
                               vend.data_venda as 'Data'
                               FROM venda vend 
                               INNER JOIN cliente cli
                               ON cli.id = vend.cliente_id
                               INNER JOIN funcionario fun
                               ON fun.id = vend.funcionario_id
                               INNER JOIN itens_venda itnvend
                               ON itnvend.venda_id = vend.id
                               INNER JOIN produto prod
                               ON prod.id = itnvend.produto_id
                               WHERE vend.cliente_id = @codCliente";
             using (MySqlCommand cmd = new MySqlCommand(cmdText, _con))
             {
                 cmd.Prepare();
                 cmd.Parameters.AddWithValue("@codCliente", codCliente);
                 reader = cmd.ExecuteReader();
                 if (reader.HasRows)
                 {
                     while (reader.Read())
                     {
                         RelatorioModel relatorioModel = new RelatorioModel();
                         relatorioModel.Cliente = (reader.GetString("Cliente"));
                         relatorioModel.Vendedor = (reader.GetString("Vendedor"));
                         relatorioModel.Produto = (reader.GetString("Produto"));
                         relatorioModel.Quantidade = (reader.GetInt32("Quantidade"));
                         relatorioModel.ValorTotal = (reader.GetDouble("ValorTotal"));
                         relatorioModel.Codigo = (reader.GetInt32("Código"));
                         relatorioModel.Data = (reader.GetDateTime("Data"));
                         _relatorioModel.Add(relatorioModel);
                     }
                 }
                 return _relatorioModel;
             }
         }
    }
}
