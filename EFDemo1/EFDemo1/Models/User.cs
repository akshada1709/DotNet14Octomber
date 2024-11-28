using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDemo1.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int UId {  get; set; }

        [Required]
        [Display(Name = "User Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "User Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
