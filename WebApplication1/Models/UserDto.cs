﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserDto
    {
        [Required,MaxLength(100)]
        public string FirstName { get; set; } = "";

        [Required,MaxLength(100)]
        public string LastName { get; set; } = "";

        [Required,EmailAddress,MaxLength(100)]
        public string Email { get; set; } = ""; // unique in the database

        [MaxLength(20)]
        public string? Phone { get; set; }

        [Required, MaxLength(100)]
        public string Address { get; set; } = "";

        [Required,MinLength(8),MaxLength(100)]
        public string Password { get; set; } = "";

      
    }
}
