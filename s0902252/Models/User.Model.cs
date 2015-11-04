using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace s0902252.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Display(Name ="Gebruikersnaam")]
        public string UserName { get; set; }
        [Required]
        [Display(Name="Voornaam")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name ="Achternaam")]
        public string SurName { get; set; }
        [Required]
        [Display(Name="Wachtwoord")]
        public string Password { get; set; }

        // Should not be visible during creation.
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        // Add foreign objects
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}