using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService2.Models;


namespace WorkerService2.DataAccess
{
    public class ProdutoRepository
    {
        private const string ConnectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ParalelismoDb;Integrated Security=True";

        SqlConnection conn;

        public ProdutoRepository()
        {
            conn = new SqlConnection(ConnectionString);
        }

        public Queue<Produto> ObterProdutos()
        {
            Queue<Produto> fila = new Queue<Produto>();
            
            string sql = "SELECT top 2500 * FROM PRODUTOS with(nolock) WHERE [STATUS] = 0";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            IDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.Id = Convert.ToInt32(reader["Id"]);
                produto.Codigo = reader["Codigo"].ToString();
                produto.Descricao = reader["Descricao"].ToString();
                produto.Robo1 = reader["Robo1"].ToString();
                produto.Robo2 = reader["Robo2"].ToString();
                produto.Robo3 = reader["Robo3"].ToString();
                produto.Status = (StatusProduto) Convert.ToInt32(reader["Status"]);

                fila.Enqueue(produto);
            }
            conn.Close();
            return fila;

        }

        public void Atualizar(Produto produto)
        {
            string sql = "UPDATE PRODUTOS SET CODIGO=@Codigo, ROBO1=@Robo1, ROBO2=@Robo2, ROBO3=@Robo3, [STATUS]=@Status WHERE Id = @Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", produto.Id);
            cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);            
            cmd.Parameters.AddWithValue("@Robo1", produto.Robo1);
            cmd.Parameters.AddWithValue("@Robo2", produto.Robo2);
            cmd.Parameters.AddWithValue("@Robo3", produto.Robo3);
            cmd.Parameters.AddWithValue("@Status", produto.Status);            
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
