using System.ComponentModel.DataAnnotations;

namespace match.Models
{
    public class UserViewModel : BaseEntity {
        [Key]
        public int Id { get; set;}

        [Required(ErrorMessage="You have a name??")]
        [MinLength(3, ErrorMessage="At least 3 chars!")]
        [MaxLength(20, ErrorMessage="It's too long!!")]
        public string Name {get; set;}

        [Required(ErrorMessage="Please provide email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage="You want Password?")]
        [MinLength(8, ErrorMessage="At least 8 chars!")]
        [DataType(DataType.Password)]
        public string Password {get; set;}

        [Required(ErrorMessage="Plase confirm password")]
        [Compare("Password", ErrorMessage="It doesn't match!! Typo?")]
        public string Confirm {get; set;}
    }
}