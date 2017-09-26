using System;
namespace match.Models
{
    public class Preference : BaseEntity {
        public int Id {get; set;}
        public int UserId {get; set;}

        public int Smoke {get; set;}
        public int Kid {get; set;}
        public int Relationship {get; set;}
        public int Drink {get; set;}
        public int Religion {get; set;}
        public int Etnicity {get; set;}
        public int BodyType{get; set;}
        public int Height {get; set;}
    }
}