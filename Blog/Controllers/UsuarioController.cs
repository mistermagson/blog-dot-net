using Blog.Dao;
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
    public class UsuarioController : Controller
    {
        private readonly UsuarioDAO usuarioDAO;

        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Autentica(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuario = usuarioDAO.Busca(loginViewModel.Login, loginViewModel.Senha);
                if(usuario != null)
                {
                    HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(usuario));
                    return RedirectToAction("Index", "Post", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("login.Invalido", "Login	ou	senha	incorretos");
                }
            }

            return View("Login",loginViewModel);
        }
    }
}
