using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public string Titulo { get; set; }
        [StringLength(50, ErrorMessage = "O campo deve conter no máximo 50 caracteres")]
        public string Resumo { get; set; }
        public string Categoria { get; set; }
        public bool Publicado { get; set; }
        public DateTime? DataPublicacao { get; set; }
    }
}
