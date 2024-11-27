using System.ComponentModel.DataAnnotations;

namespace WebApplicationDemo.Models
{
    public class User
    {
        [Required(ErrorMessage ="name is required")]
        [MaxLength(100)]
        [MinLength(4)]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "mail is required")]
        [MaxLength(100)]
        [MinLength(7)]
        [DataType(DataType.EmailAddress)]
        public string? Email {  get; set; }

        [Required(ErrorMessage = "age is required")]
        [Range(minimum:18,maximum:60)]
        public int Age {  get; set; }

        [Required(ErrorMessage = "password is required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="password does not match")]
        public string? ConfirmPassword { get; set; }

    }
}
