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
                return context.Posts.ToList();
            }
             
        }

        public IList<Post> ListaPublicados()
        {
            using (BlogContext context = new BlogContext())
            {
                return context.Posts.Where(p => p.Publicado)
                    .OrderByDescending(p => p.DataPublicacao)
                    .ToList();
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

        public List<Post> BuscaPorCategoria(string categoria)
        {
            using (BlogContext context = new BlogContext())
            {
                return context.Posts
                    .Where(p => p.Categoria.Contains(categoria))
                    .ToList();
            }
        }

        public void Remove(int id)
        {
            using (BlogContext context = new BlogContext())
            {
                var post = context.Posts.Find(id);
                context.Remove(post);
                context.SaveChanges();
            }
        }

        public Post BuscaPorId(int id)
        {
            using (BlogContext context = new BlogContext())
            {
                return context.Posts.Find(id);
            }
         }

        public void Altera(Post post)
        {
            using (BlogContext context = new BlogContext())
            {
                context.Entry(post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                //context.Posts.Update(post);
                context.SaveChanges();
            }
        }

        public IList<string> ListaCategoriasQueContemTermo(string termo)
        {
            using (var contexto = new BlogContext()) {
                return contexto.Posts.Where(p => p.Categoria.Contains(termo))
                    .Select(p => p.Categoria).Distinct().ToList(); }
        }

        public IList<Post> BuscaPeloTermo(string termo)
        {
            using (var contexto = new BlogContext())
            {
                return contexto.Posts.Where(p => p.Publicado && (p.Titulo.Contains(termo) || p.Resumo.Contains(termo)))
                    .ToList();
                
            }
                
        }
        //internal void Publica(int id)
        //{
        //    using (BlogContext context = new BlogContext())
        //    {
        //         var post = context.Posts.Find(id);
        //        post.DataPublicacao = DateTime.Now;
        //        post.Publicado = true;
        //        context.SaveChanges();
        //    }
        //}
    }
}
