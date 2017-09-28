using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace match.Models
{
    public class Conversing : BaseEntity 
    {
        public Conversing()
        {
            Senders = new List<Message>();
            Receivers = new List<Message>();
        }

        public int ConversingId {get; set;}

         [InverseProperty("Receivers")]
         public List<Message> Senders { get; set; }
         

         [InverseProperty("Senders")]
         public List<Message> Receivers { get; set; }
        
    }
    
}