using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Dao;
using Blog.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Areas.API
{
    [Area ("API")]
    [Route("api/[controller]")]
    [ApiController]
    public class PostApiController : ControllerBase
    {
        private readonly PostDAO postDAO;

        public PostApiController(PostDAO postDAO)
        {
            this.postDAO = postDAO;
        }

        [HttpGet]
        [Route("lista")]
        public IActionResult ListaPosts()
        {
            List<Post> posts = postDAO.Lista();
            return Ok(posts);
        }

        [HttpGet]
        [Route ("{id}")]
        public IActionResult BuscaPorId(int id)
        {
            Post p = postDAO.BuscaPorId(id);
            return Ok(p);
        }

        [HttpPost]
        [Route("novo")]
        public IActionResult Novo([FromBody] Post p)
        {
            postDAO.Adiciona(p);
            return Created("/api/post/" + p.Id, p);
        }
    }
}