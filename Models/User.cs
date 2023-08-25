﻿using System.ComponentModel.DataAnnotations;

namespace BangazonBackend.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        public bool? IsSeller { get; set; }
        //public List<Order> Orders { get; set; }
    }
}