using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private List<Post> lista;

        public PostController()
        {

            lista = new List<Post>
            {
                new Post
            {
                Titulo = "Vingadores Guerra Infinita",
                Categoria = "Aventura",
                Resumo = "O filme da Marvel ......"
            },
                new Post
            {
                Titulo = "Shaft",
                Categoria = "Ação",
                Resumo = "O filme Shaft ......"
            },
                new Post
            {
                Titulo = "A Era do Gelo 4",
                Categoria = "Animação",
                Resumo = "O filme conta a história ......"
            },
                new Post
            {
                Titulo = "Star Wars The Rise of Skywalker",
                Categoria = "Ficção",
                Resumo = "O filme Star Wars ......"
            },
                new Post
            {
                Titulo = "Chorona",
                Categoria = "Terror",
                Resumo = "O filme ......"
            }
        };
          
        }

     
        public IActionResult Index()
        {
           // ViewBag.ListaPost = posts;

            return View(lista);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adiciona(Post post)
        {
           
            lista.Add(post);

            return View("Index", lista);
        }
    }
}
