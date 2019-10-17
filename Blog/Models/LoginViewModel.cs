﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class LoginViewModel
    {

        [Required]
        public string Senha { get; set; }

        [Required]
        public string Login { get; set; }

    }
}
