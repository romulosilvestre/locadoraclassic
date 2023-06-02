using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{
    public class CategoriaDAL
    {
        public void InserirCategoria(Categoria categoria)
        {

            //Abrir a Conexão
            Conexao.Instance.Open();
            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE -SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO categoria(nome,vlDiaria)values(@nome,@vlDiaria)";
            comando.Parameters.Add(new MySqlParameter("@nome", categoria.Nome));
            comando.Parameters.Add(new MySqlParameter("@vlDiaria", categoria.vlDiaria));
            comando.ExecuteNonQuery();
            //Fechou conexão
            Conexao.Instance.Close();

        }

        public List<Categoria> ObterCategorias()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM categoria";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Categoria> categorias = new List<Categoria>();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Id = Convert.ToInt32(reader["id"]);
                categoria.Nome = reader["nome"].ToString();
                categoria.vlDiaria = Convert.ToDecimal(reader["vlDiaria"]);               
                categorias.Add(categoria);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return categorias;
        }
        public void AtualizarCategoria(Categoria categoria)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE categoria SET nome = @nome WHERE id = @id";
            comando.Parameters.AddWithValue("@nome", categoria.Nome);
            comando.Parameters.AddWithValue("@id", categoria.Id);
            comando.ExecuteNonQuery();
            // Fechar a conexão
            Conexao.Instance.Close();
        }
        public void ExcluirCategoria(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM categoria WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            // Fechar a conexão
            Conexao.Instance.Close();
        }
    }
}