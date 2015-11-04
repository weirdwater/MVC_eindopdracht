using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace s0902252.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name="Categorie")]
        public string CategoryName { get; set; }

        // Add foreign objects
        public virtual ICollection<Review> Reviews { get; set; }
    }
}