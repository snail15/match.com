using System;
using System.ComponentModel.DataAnnotations;

namespace match.Models
{
    public class UserdetailViewModel : BaseEntity {
        [Key]
        public int UserdetailsId {get; set;}

        [Required(ErrorMessage="Cannot create a profile for a non-user")]
        [Range(1, Int32.MaxValue, ErrorMessage="The value has to be a number")]
        public int UserId {get; set;}

        [Required(ErrorMessage="You need to choose a gender option")]
        public string gender {get; set;}

        [Required(ErrorMessage="Please include your first name")]
        [MinLength(2, ErrorMessage="First name has to be at least 2 characters long")]
        public string givenname {get; set;}

        [MaxLength(1, ErrorMessage="Please just include the initial letter")]
        public string middleinitial {get; set;}

        [Required(ErrorMessage="Please include your last name")]
        [MinLength(2, ErrorMessage="Last name has to be at least 2 characters long")]
        public string surname {get; set;}

        [Required(ErrorMessage="Please include your address")]
        [MinLength(4, ErrorMessage="Last name has to be at least 4 characters long")]
        public string streetaddress {get; set;}

        [Required(ErrorMessage="Please include your current City")]
        // [MinLength(4, ErrorMessage="Last name has to be at least 4 characters long")]
        public string city {get; set;}

        [Required(ErrorMessage="Please include your current State")]
        [MinLength(2, ErrorMessage="Only the 2 letter initials")]
        [MaxLength(2, ErrorMessage="Only the 2 letter initials")]
        public string state {get; set;}

        [Required(ErrorMessage="Please include your current zip code")]
        [MinLength(5, ErrorMessage="Only 5 digits")]
        [MaxLength(5, ErrorMessage="Only 5 digits")]
        public int zipcode {get; set;}
    }
}