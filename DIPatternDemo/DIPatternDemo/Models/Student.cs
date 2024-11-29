using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DIPatternDemo.Models
{
    [Table("student")]
    public class Student
    {
        [Key]
        public int StdRollNo { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string? StdName { get; set; }

        [Required]
        [Display(Name = "Student Branch")]
        public string? StdBranch { get; set; }

        [Display(Name = "Student Percentage")]
        [Required]
        public double StdPercentage { get; set; }
    }
}
