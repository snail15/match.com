using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace match.Models
{
    public class Wrapper : BaseEntity 
    {
        public List<User> Users {get; set;}
        public List<Userdetail> Userdetails {get; set;}
        public List<Userprofile> Userprofiles {get; set;}
        public List<Userpreference> Userpreferences {get; set;}
        public List<Userpayment> Userpayments {get; set;}
        public List<Userbioactivity> Userbioactivities {get; set;}
        public Wrapper(List<User> u,List<Userdetail> d,List<Userprofile> p, List<Userpreference> r,List<Userpayment> y,List<Userbioactivity> b)
        {
            Users = u;
            Userdetails = d;
            Userprofiles = p;
            Userpreferences = r;
            Userpayments = y;
            Userbioactivities = b;
        }

    }
}
