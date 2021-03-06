using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace match.Models
{
    public class MessageViewModel : BaseEntity {
        [Key]
        public int Id {get; set;}
// ========================================================================================
// ========================================================================================

        [Required(ErrorMessage= "Message can not be empty. Don't be shy, say something.")]
        [MinLength(3, ErrorMessage="Message must be at least 3 characters long. We know how many of you only send 'Hey'")]
        public string messageContent {get; set;}
// ========================================================================================
// ========================================================================================
        
    }
}