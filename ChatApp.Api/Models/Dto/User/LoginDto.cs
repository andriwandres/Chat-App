﻿using System.ComponentModel.DataAnnotations;

namespace ChatApp.Api.Models.Dto.User
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\S+$")]
        public string Password { get; set; }
    }
}
