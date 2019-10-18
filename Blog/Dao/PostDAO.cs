using Blog.Infra;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Blog.Dao
{
    public class PostDAO
    {
        private BlogContext context;

        public PostDAO(BlogContext context)
        {
            this.context = context;
        }

        public List<Post> Lista()
        {
            return context.Posts.Include(p => p.Autor).ToList();
        }

        public IList<Post> ListaPublicados()
        {
            return context.Posts.Include(p => p.Autor).Where(p => p.Publicado)
                .OrderByDescending(p => p.DataPublicacao)
                .ToList();
        }

        public void Adiciona(Post p)
        {
            context.Posts.Add(p);
            context.SaveChanges();
        }

        public void Adiciona(Post p, Usuario u)
        {
            context.Usuarios.Attach(u);
            p.Autor = u;
            context.Posts.Add(p);
            context.SaveChanges();
        }

        public List<Post> BuscaPorCategoria(string categoria)
        {
            return context.Posts
                .Where(p => p.Categoria.Contains(categoria))
                .ToList();
        }

        public void Remove(int id)
        {
            var post = context.Posts.Find(id);
            context.Remove(post);
            context.SaveChanges();
        }

        public Post BuscaPorId(int id)
        {
            return context.Posts.Find(id);
        }

        public void Altera(Post post)
        {
            context.Entry(post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public IList<string> ListaCategoriasQueContemTermo(string termo)
        {
            return context.Posts.Where(p => p.Categoria.Contains(termo))
                .Select(p => p.Categoria).Distinct().ToList();
        }

        public IList<Post> BuscaPeloTermo(string termo)
        {
            return context.Posts.Where(p => p.Publicado && (p.Titulo.Contains(termo) || p.Resumo.Contains(termo)))
                .ToList();
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
