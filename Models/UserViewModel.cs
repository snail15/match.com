using System;
using System.ComponentModel.DataAnnotations;

namespace match.Models
{
    public class UserViewModel : BaseEntity {
        [Key]
        public int UserId {get; set;}

        [Required(ErrorMessage="Please include an e-mail address")]
        [EmailAddress]
        public string email {get; set;}

        [Required(ErrorMessage="Please include a password")]
        [MinLength(8, ErrorMessage="The password has to be at least 8 characters long")]
        public string password {get; set;}

        [Required(ErrorMessage="Please confirm the password entered")]
        [Compare("password", ErrorMessage="Password confirmation does not match")]
        public string confirmpass {get; set;}

        [Required(ErrorMessage="Please include your birthday")]
        [DataType(DataType.DateTime)]     
        public DateTime birthday {get; set;}
    }
}