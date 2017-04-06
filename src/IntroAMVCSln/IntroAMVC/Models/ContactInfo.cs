using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IntroAMVC.Models
{
    public class ContactInfo
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}