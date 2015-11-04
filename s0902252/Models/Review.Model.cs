using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace s0902252.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [Display(Name = "Productnaam")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Resencie")]
        public string ReviewBody { get; set; }

        // Should not be visible at creation
        public DateTime Published { get; set; }
        public bool IsActive { get; set; }

        // Add foreign objects
        public int UserId { get; set; }
        public virtual User User { get; set;}
    }
}