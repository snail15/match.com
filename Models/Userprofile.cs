using System;
namespace match.Models
{
    public class Userprofile : BaseEntity 
    {
        public int UserprofileId {get; set;}
        public int UserId {get; set;}
        public string bodytype {get;set;}
        public string smoke {get; set;}
        public int? salary {get; set;}
        public string height {get;set;}
        public string weight {get;set;}
        public string Relationship { get; set; }
        //-----------------------------
        // public string gender {get; set;} //varchar(6) NOT NULL,
        // public string nameset {get; set;}//varchar(25) NOT NULL,
        // public string givenname {get; set;}//varchar(20) NOT NULL,
        // public string middleinitial {get; set;}//varchar(1) NOT NULL,
        // public string surname {get; set;}//varchar(23) NOT NULL,
        // public string streetaddress {get; set;}//varchar(100) NOT NULL,
        // public string city {get; set;}//varchar(100) NOT NULL,
        // public string state {get; set;}//varchar(22) NOT NULL,
        // public string zipcode {get; set;}//varchar(15) NOT NULL,
        // public string email {get; set;}//varchar(100) NOT NULL,
        // public string username {get; set;}//varchar(25) NOT NULL,
        // public string password {get; set;}//varchar(25) NOT NULL,
        // public string telephonenumber {get; set;}//varchar(25) NOT NULL,
        // public int telephonecountrycode {get; set;}//int NOT NULL,
        // public string maidenname {get; set;}//varchar(20) NOT NULL,
        // public string birthday {get; set;}//varchar(10) NOT NULL,
        // public int age {get; set;}//int NOT NULL,
        // public string tropicalzodiac {get; set;}//varchar(11) NOT NULL,
        // public string cctype {get; set;}//varchar(10) NOT NULL,
        // public string ccnumber {get; set;}//varchar(16) NOT NULL,
        // public string CVV2 {get; set;}//varchar(3) NOT NULL,
        // public string ccexpires {get; set;}//varchar(10) NOT NULL,
        // public string nationalid {get; set;}//varchar(20) NOT NULL,
        // public string color {get; set;}//varchar(6) NOT NULL,
        // public string occupation {get; set;}//varchar(70) NOT NULL,
        //-----------------------------
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}    
    }
}