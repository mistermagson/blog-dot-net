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
        private readonly PostDAO postDAO;

        public HomeController(PostDAO postDAO)
        {
            this.postDAO = postDAO;
        }

        public IActionResult Index()
        {
            IList<Post> posts = postDAO.ListaPublicados();
            return View(posts);
        }

        public IActionResult Busca(string termo)
        {
            IList<Post> posts = postDAO.BuscaPeloTermo(termo);
            return View("Index", posts);
        }
    }
}
