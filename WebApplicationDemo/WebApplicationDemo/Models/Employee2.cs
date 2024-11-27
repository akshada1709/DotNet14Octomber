using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplicationDemo.Models
{
    public class Employee2
    {
        [Required(ErrorMessage = "id is required")]
       
        public int Id { get; set; }

        [Required(ErrorMessage = "name is required")]
        [MaxLength(50)]
        [MinLength(4)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "mail is required")]
        [MaxLength(100)]
        [MinLength(7)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }


        [Required(ErrorMessage = "age is required")]
        [Range(minimum: 18, maximum: 60)]
        public int Age { get; set; }


        [Required(ErrorMessage = "department is required")]
        public string? Dept {  get; set; }

        [Required(ErrorMessage = "salary is required")]
        public int Salary { get; set; }
    }
}
