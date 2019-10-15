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
            using(BlogContext context = new BlogContext())
            {
                var lista = context.Posts.ToList();
                return lista;
            }
             
        }

        public void Adiciona(Post p)
        {
            using (BlogContext context = new BlogContext())
            {
                context.Posts.Add(p);
                context.SaveChanges();
            }
        }
    }
}
