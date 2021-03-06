﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace s0902252.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        [Range(1, 5)]
        [Display(Name="Beoordeling")]
        public int RatingValue { get; set; }

        // Add foreign objects
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int ReviewId { get; set; }
        public virtual Review Review { get; set; }
    }
}