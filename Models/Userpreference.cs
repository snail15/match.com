using System;
namespace match.Models
{
    public class Userpreference : BaseEntity 
    {
        public int UserpreferenceId {get;set;}
        public User User {get; set;}
        public int UserId {get; set;}
        public Userdetail Userdetail {get; set;}
        public int UserdetailId {get; set;}
        public Userprofile Userprofile {get;set;}
        public int UserprofileId {get; set;}
        public string genderpref {get;set;}
        public int? bodytypepref {get;set;}
        public int? smokepref {get;set;}
        public int? salarypref {get;set;}
        public string heightpref {get;set;}
        public int? distance {get;set;}
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public string drinkpref {get;set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}  
    }
}