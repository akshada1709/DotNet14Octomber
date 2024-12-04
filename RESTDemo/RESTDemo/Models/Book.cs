
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDemo.Models
{
    [Table("book")]
    public class Book
    {
        [Key]
        public int BId { get; set; }
        [Required]
        public string Name {  get; set; }
        [Required]
        public string Author {  get; set; }
        [Required]
        public int Price {  get; set; }
    }
}
