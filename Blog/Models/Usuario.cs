﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Nome { get; set; }

        List<Post> posts { get; set; }
    }
}
