using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPatternDemo1.Models
{
    [Table("student1")]
    public class Student
    {
        [Key]
        public int RollNo { get; set; }

        [Required]
        public string? Name { get; set; }

   
        public int? Percentage { get; set; }

        [Required]
        public string? Branch { get; set; }
    }
}
