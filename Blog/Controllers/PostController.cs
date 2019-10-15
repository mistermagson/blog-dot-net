using Blog.Dao;
using Blog.Infra;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class PostController : Controller
    {

        public IActionResult Index()
        {
            // ViewBag.ListaPost = posts;

            List<Post> posts = new PostDAO().Lista();
            return View(posts);

        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adiciona(Post post)
        {

            PostDAO dao = new PostDAO();
            dao.Adiciona(post);

            List<Post> lista = dao.Lista();

            return RedirectToAction("Index");
        }
    }
}
