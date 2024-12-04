using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartialViewDemo.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id {  get; set; }
        public string? Name { get; set; }
        public string? CompanyName {  get; set; }
        public int Price {  get; set; }
    }
}
