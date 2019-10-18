using Blog.Infra;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Dao
{
    public class UsuarioDAO
    {
        private readonly BlogContext context;

        public UsuarioDAO(BlogContext context)
        {
            this.context = context;
        }

        public Usuario Busca(string login, string senha)
        {
            return context.Usuarios.FirstOrDefault(u => u.Email == login && u.Senha == senha);
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public List<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }

        public void Altera(Usuario usuario)
        {
            context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public Usuario BuscaUsuarioPorId(int id)
        {
            return context.Usuarios.Find(id);
        }

        public void Remove(int id)
        {
            var usuario = BuscaUsuarioPorId(id);
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
    }
}
