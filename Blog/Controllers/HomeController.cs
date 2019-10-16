using Blog.Dao;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            PostDAO dao = new PostDAO();
            IList<Post> posts = dao.ListaPublicados();
            return View(posts);
        }

        public IActionResult Busca(string termo)
        {
            PostDAO dao = new PostDAO();
            IList<Post> posts = dao.BuscaPeloTermo(termo);
            return View("Index", posts);
        }
    }
}
