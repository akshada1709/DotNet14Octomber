using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo1.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key] 
        public int EmpId {  get; set; }
        [Required]
        [Display(Name="Employee Name")]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Employee Email")]
        [DataType(DataType.EmailAddress)]
        public string? Email {  get; set; }
        [Required]
        [Display(Name="Employee Salary")]
        public int Salary {  get; set; }


    }
}
