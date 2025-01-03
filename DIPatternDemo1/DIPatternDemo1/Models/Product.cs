﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPatternDemo1.Models
{
    [Table("Product1")]
    public class Product
    {
        [Key]

        public int ProductId {  get; set; }
        [Required]
        public string? ProductName { get; set; }
        [Required]
        public int Price {  get; set; }
        [Required]
        public int CategoryId {  get; set; }

        public string? ImageUrl { get; set; }
        [NotMapped] //do not map this categor
        public string? CategoryName { get; set; }
    }
}
