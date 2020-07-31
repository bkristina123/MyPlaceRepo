using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyPlace.Data
{
    public class UserImage
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
