using Blog.Infra;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Dao
{
    public class PostDAO
    {
        public List<Post> Lista()
        {
            using (SqlConnection connection = ConnectionFactory.CriaConexaoAberta())
            {
                SqlCommand comando = connection.CreateCommand();
                comando.CommandText = "select * from Posts";
                IDataReader leitor = comando.ExecuteReader();

                List<Post> posts = new List<Post>();

                while (leitor.Read())
                {
                    posts.Add(new Post
                    {
                        Id = Convert.ToInt32(leitor["id"]),
                        Titulo = leitor["titulo"].ToString(),
                        Resumo = leitor["resumo"].ToString(),
                        Categoria = leitor["categoria"].ToString()
                    });
                }
                return posts;
            }
        }

        public void Adiciona(Post p)
        {
            using (SqlConnection connection = ConnectionFactory.CriaConexaoAberta())
            {
                SqlCommand comando = connection.CreateCommand();
                comando.CommandText = $"insert into Posts (Titulo, Resumo, Categoria) values (@titulo, @resumo, @categoria)";

                comando.Parameters.Add(new SqlParameter("titulo", p.Titulo));
                comando.Parameters.Add(new SqlParameter("resumo", p.Resumo));
                comando.Parameters.Add(new SqlParameter("categoria", p.Categoria));

                comando.ExecuteNonQuery();
                
                
            }
        }
    }
}
