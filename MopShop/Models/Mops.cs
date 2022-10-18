using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MopShop.Models
{
    public class Mops
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }

        [Display(Name = "Cleaning Purpose")]
        public string CleaningPurpose { get; set; }

        [Display(Name = "Type of Surface")]
        public string TypeOfSurface { get; set; }

        public string Material { get; set; }

        public decimal Price { get; set; }

        [Display(Name = "Customer Rating")]
        public int CustomerRating { get; set; }

        [Display(Name = "Product Image")]
        public string ProductImage { get; set; }
    }
}

