using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using match.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace match.Controllers
{
    public class HomeController : Controller
    {
        private MatchContext context;

        public HomeController(MatchContext _context)
        {
            context = _context;
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Index(UserViewModel model){
            
            if(ModelState.IsValid)
            {
                User newUser = new User{
                    email = model.email,
                    password = model.password,
                    birthday = model.birthday,
                };
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.password = hasher.HashPassword(newUser, model.password);
                context.Add(newUser);
                context.SaveChanges();
                HttpContext.Session.SetInt32("currentUserId", newUser.UserId);
                return RedirectToAction("GeneralInfo");
            } 
            else 
            {
                return View();
            }
           
        }


        [HttpGet]
        [Route("/generalinfo")]
        public IActionResult GeneralInfo() {
            return View();
        }

        // [HttpPost]
        // [Route("/generalinfo")]
        // public IActionResult GeneralInfo(string month, string day, string year, string foot, string inch, string drink, string religion, string smoke, string ethnicity, string relationship, string kids, string minage, string maxage, string bodytype ) {

        //     if(month == "0" || day ==  "0" || year == "0" || foot == "0" || inch == "-1"){
        //         ViewBag.Error = "All Fields Are Required!";
        //         return View();
        //     }
        //     // Parsing relevant data
        //     string birthdayString = year + "," + month + "," + day;
        //     DateTime birthday = DateTime.Parse(birthdayString);
        //     TimeSpan ageNow = DateTime.Now - birthday;
        //     int age = (int)ageNow.TotalDays/365;
        //     int intFoot = Int32.Parse(foot);
        //     int intInch = Int32.Parse(inch);
        //     int height = (intFoot * 12) + intInch;
        //     int intDrink = Int32.Parse(drink);
        //     int intRelationship = Int32.Parse(relationship);
        //     int intSmoke = Int32.Parse(smoke);
        //     int intKids = Int32.Parse(kids);
        //     int intMinAge = Int32.Parse(minage);
        //     int intMaxAge = Int32.Parse(maxage);
        //     int intBodyType = Int32.Parse(bodytype);

        //     // Add data to the current user             
        //     int? userId = HttpContext.Session.GetInt32("currentUserId");
        //     User currentUser = context.Users.SingleOrDefault(u => u.Id == userId);
        //     currentUser.Age = age;
        //     currentUser.Birthday = birthday;
        //     currentUser.Height = height;
        //     currentUser.Drink = intDrink;
        //     currentUser.Relationship = intRelationship;
        //     currentUser.Smoke = intSmoke;
        //     currentUser.Kid = intKids;
        //     currentUser.MinAge = intMinAge;
        //     currentUser.MaxAge = intMaxAge;
        //     currentUser.BodyType = intBodyType;
        //     context.SaveChanges();
        //     return RedirectToAction("Preference");

        // }

        [HttpGet]
        [Route("/preference")]
        public IActionResult Preference() {
            return View();
        }

        // [HttpPost]
        // [Route("/preference")]
        // public IActionResult Preference(string smoke, string relationship, string drink, string religion, string bodytype, string ethnicity, string kid, string foot, string inch) {

        //     int? userId = HttpContext.Session.GetInt32("currentUserId");

        //     // Parse all the data
        //     int intSmoke = Int32.Parse(smoke);
        //     int intKid = Int32.Parse(kid);
        //     int intRelationship = Int32.Parse(relationship);
        //     int intDrink = Int32.Parse(drink);
        //     int intReligion = Int32.Parse(religion);
        //     int intEthnicity = Int32.Parse(ethnicity);
        //     int intBodyType = Int32.Parse(bodytype);
        //     int intFoot = Int32.Parse(foot);
        //     int intInch = Int32.Parse(inch);
        //     int height = (intFoot * 12) + intInch;

        //     Preference newPreference = new Preference {
        //         UserId = (int)userId,
        //         Smoke = intSmoke,
        //         Kid = intKid,
        //         Relationship = intRelationship,
        //         Drink = intDrink,
        //         Religion = intReligion,
        //         Etnicity = intEthnicity,
        //         BodyType = intBodyType,
        //         Height = height

        //     };

        //     context.Add(newPreference);
        //     context.SaveChanges();
        //     return RedirectToAction("Dashboard");
        // }

        [HttpGet]
        [Route("/dashboard")]
        public IActionResult Dashboard() {
            return View();
        }


    }
}
