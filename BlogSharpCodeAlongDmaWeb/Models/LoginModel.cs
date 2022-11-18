﻿using System.ComponentModel.DataAnnotations;

namespace BlogSharpCodeAlongDmaWeb.Models
{
    public class LoginModel
    {
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}
