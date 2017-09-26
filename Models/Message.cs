using System;
using System.Collections.Generic;

namespace match.Models
{
    public class Message : BaseEntity {

        public int Id {get; set;}
        public string sender {get; set;}
        public string receiver {get; set;}
        public string messageContent {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
    }
}