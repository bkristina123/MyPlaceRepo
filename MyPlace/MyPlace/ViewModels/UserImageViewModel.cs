using System;
using System.ComponentModel.DataAnnotations;

namespace MyPlace.ViewModels
{
    public class UserImageViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
    }
}
