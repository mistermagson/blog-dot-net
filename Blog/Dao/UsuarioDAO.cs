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
    }
}
