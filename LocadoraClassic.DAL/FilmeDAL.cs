using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public void InserirFilme(Filme filme)
        {
            Conexao.Instance.Open();
            string query = "INSERT INTO filme (nome, duracao, sinopse, stlocado, banner, idcategoria, idgenero) " +
                               "VALUES (@Nome, @Duracao, @Sinopse, @StLocado, @Banner, @IdCategoria, @IdGenero)";

                MySqlCommand command = Conexao.Instance.CreateCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@Nome", filme.Nome);
                command.Parameters.AddWithValue("@Duracao", filme.Duracao);
                command.Parameters.AddWithValue("@Sinopse", filme.Sinopse);
                command.Parameters.AddWithValue("@StLocado", filme.StLocado);
                command.Parameters.AddWithValue("@Banner", filme.Banner);
                command.Parameters.AddWithValue("@IdCategoria", filme.IdCategoria);
                command.Parameters.AddWithValue("@IdGenero", filme.IdGenero);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Trate a exceção adequadamente ou lance para cima para tratamento em outro lugar
                    throw;
                }
            
        }
    }
}
