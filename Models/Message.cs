using System;
using System.Collections.Generic;

namespace match.Models
{
    public class Message : BaseEntity {

        public int Id {get; set;}
        public int senderId {get; set;}
        public int receiverId {get; set;}
        public string messageContent {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
    
}