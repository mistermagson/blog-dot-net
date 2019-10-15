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
            return View(new Post());
        }

        [HttpPost]
        public IActionResult Adiciona(Post post)
        {
            if (ModelState.IsValid)
            {
                PostDAO dao = new PostDAO();
                dao.Adiciona(post);

                List<Post> lista = dao.Lista();

                return RedirectToAction("Index");

            }
            else
            {
                return View("Novo", post);
            }

        }

        
        public IActionResult Categoria([Bind(Prefix ="id")] string categoria)
        {
            PostDAO dao = new PostDAO();

            List<Post> posts = dao.BuscaPorCategoria(categoria);

            return View("Index",posts);
        }

        public IActionResult Delete(int id)
        {
            PostDAO dao = new PostDAO();
            dao.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Visualiza(int id)
        {
            PostDAO dao = new PostDAO();
            var post = dao.BuscaPorId(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult Altera(Post post)
        {

            PostDAO dao = new PostDAO();
            dao.Altera(post);

            List<Post> lista = dao.Lista();

            return RedirectToAction("Index");
        }

        
        public IActionResult PublicaPost(int id)
        {
            PostDAO dao = new PostDAO();

            var post = dao.BuscaPorId(id);

            post.DataPublicacao = DateTime.Now;
            post.Publicado = true;

            dao.Altera(post);

            List<Post> lista = dao.Lista();

            return RedirectToAction("Index");
        }
    }
}
