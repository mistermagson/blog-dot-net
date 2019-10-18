using Blog.Dao;
using Blog.Filters;
using Blog.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    [Area("Admin")]
    [AutorizacaoFilter]
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO usuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        public IActionResult Index()
        {
            List<Usuario> usuarios = usuarioDAO.Lista();
            return View(usuarios);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adiciona(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuarioDAO.Adiciona(usuario);
                return RedirectToAction("Index");
            }
            return View("Novo", usuario);
        }

        public IActionResult Visualiza(int id)
        {
            var usuario = usuarioDAO.BuscaUsuarioPorId(id);
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Altera(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuarioDAO.Altera(usuario);
                return RedirectToAction("Index");

            }

            return View("Visualiza", usuario);
        }

        public IActionResult Delete(int id)
        {
            usuarioDAO.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
