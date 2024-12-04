using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RESTDemo.Models
{
    [Table("student1")]
    public class Student
    {
        [Key]
        public int rollNo {  get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public int percentage {  get; set; }
        [Required]
        public string branch {  get; set; }
    }
}
