using System;
using System.Collections.Generic;

namespace match.Models
{
    public class Reply : BaseEntity {

        public int Id {get; set;}
        public int messageId {get; set;}
        public int senderId {get; set;}
        public string replyContent {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
        public Message Message {get; set;}
    }
}