using Blog.Dao;
using Blog.Filters;
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
    [Area("Admin")]
    [AutorizacaoFilter]
    public class PostController : Controller
    {
        private readonly PostDAO postDAO;

        public PostController(PostDAO postDAO)
        {
            this.postDAO = postDAO;
        }

        public IActionResult Index()
        {
            // ViewBag.ListaPost = posts;

            List<Post> posts = postDAO.Lista();
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
                postDAO.Adiciona(post);

                List<Post> lista = postDAO.Lista();

                return RedirectToAction("Index");

            }
            else
            {
                return View("Novo", post);
            }

        }

        
        public IActionResult Categoria([Bind(Prefix ="id")] string categoria)
        {
            List<Post> posts = postDAO.BuscaPorCategoria(categoria);
            return View("Index",posts);
        }

        public IActionResult Delete(int id)
        {
           postDAO.Remove(id);
            return RedirectToAction("Index");
        }

        public IActionResult Visualiza(int id)
        {
            
            var post = postDAO.BuscaPorId(id);

            return View(post);
        }

        [HttpPost]
        public IActionResult Altera(Post post)
        {

            postDAO.Altera(post);

            postDAO.Lista();

            return RedirectToAction("Index");
        }

        
        public IActionResult PublicaPost(int id)
        {
            var post = postDAO.BuscaPorId(id);

            post.DataPublicacao = DateTime.Now;
            post.Publicado = true;

            postDAO.Altera(post);

            List<Post> lista = postDAO.Lista();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CategoriaAutocomplete(string termoDigitado)
        {
            var model = postDAO.ListaCategoriasQueContemTermo(termoDigitado);
            return Json(model);

        }
    }
}
