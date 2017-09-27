using System;
namespace match.Models
{
    public class Userbioactivity : BaseEntity 
    {
        public int UserbioactivitiesId {get; set;}
        public User User {get; set;}
        public int UserId {get; set;}
        public Userdetail Userdetail {get; set;}
        public int UserdetailId {get; set;}
        public Userprofile Userprofile {get;set;}
        public int UserprofileId {get; set;}
        public Userpreference Userpreference {get;set;}
        public int UserpreferenceId {get;set;}
        public bool hiking {get; set;}
        public bool cooking {get; set;}
        public bool travelling {get; set;}
        public bool movies {get; set;}
        public bool sports {get; set;}
        public bool romance {get; set;}
        public bool beach {get; set;}
        public bool reading {get; set;}
        public string aboutme {get; set;}       
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
    }
}