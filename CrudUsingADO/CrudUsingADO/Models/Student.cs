using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudUsingADO.Models
{
    public class Student
    {
        [Required]
        [Display(Name = "Student RollNo")]

        public int RollNo { get; set; }
        
        [Required]
        [Display(Name = "Student Name")]
        public string? Name { get; set; }

        [Required]
        [Display(Name="Student Percentage")]

        public int Percentage {  get; set; }

        [Required]
        [Display(Name="Student Branch")]
        public string? Branch {  get; set; }

    }
}
