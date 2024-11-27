using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo1.Models
{
    [Table("book")]
    public class Book
    {
        [Key]
        public int BId { get; set; }
        [Required]
        [Display(Name = "Book Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Author Name")]

        public string? Autor { get; set; }
        [Required]
        [Display(Name = "Book price")]
        public int Price { get; set; }
    }
}
