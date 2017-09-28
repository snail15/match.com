using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore; // <-- needed to include sub models
using System.Linq;
using Microsoft.AspNetCore.Session;
using match.Models;

namespace match.Controllers
{
    public class HomeController : Controller
    {
        private MatchContext _context;

        public HomeController(MatchContext context)
        {
            _context = context;
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
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("currentUserId", newUser.UserId);
                return RedirectToAction("GeneralInfo");
            } 
            else 
            {
                return View();
            }
           
        }

        [HttpPost]
        [Route("/login")]
        public IActionResult Login(string email, string password)
        {
            User loginuser = _context.Users.SingleOrDefault(user => user.email == email);
            if(loginuser == null)
            {
                TempData["UsernameError"] = "Incorrect username";
                // TempData["UsernameError"] = ViewBag.UsernameError;
                return RedirectToAction("Index");
            }
            else
            {
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                if(hasher.VerifyHashedPassword(loginuser, loginuser.password, password) != 0)
                {
                    HttpContext.Session.SetInt32("currentUserId", loginuser.UserId);
                    return RedirectToAction("Preference");
                } 
                else 
                {
                    TempData["PasswordError"] = "Incorrect password";
                    // TempData["PasswordError"] = ViewBag.PasswordError;
                    return RedirectToAction("Index");
                }
            }
        }


        [HttpGet]
        [Route("/generalinfo")]
        public IActionResult GeneralInfo() 
        {
            // int? userId = HttpContext.Session.GetInt32("currentUserId");
            // if(userId == null)
            // {
            //     TempData["LogErrors"] = "You need to log in first";
            //     return RedirectToAction("Index");
            // }
            // else
            // {
                return View();
            // }
        }

        [HttpGet]
        [Route("/adddetails")]
        public IActionResult Adddetails(UserdetailViewModel model) 
        {
            int? userId = HttpContext.Session.GetInt32("currentUserId");
            if(userId == null)
            {
                TempData["LogErrors"] = "You need to log in first";
                return RedirectToAction("Index");
            }
            else
            {
                if(ModelState.IsValid)
                {
                    // var today = DateTime.Today;
                    // // Calculate the age.
                    // var age = today.Year - model.birthday.Year;
                    // // Go back to the year the person was born in case of a leap year
                    // if (birthdate > today.AddYears(-age)) age--;
                    Userdetail newDetail = new Userdetail{
                        gender = model.gender,
                        givenname = model.givenname,
                        middleinitial = model.middleinitial,
                        surname = model.surname,
                        streetaddress = model.streetaddress,
                        city = model.city,
                        state = model.state,
                        // zipcode = model.zipcode,
                    };
                    _context.Add(newDetail);
                    _context.SaveChanges();
                    Userprofile userprofile = _context.Userprofiles.SingleOrDefault(profile => profile.UserId == userId);
                    if(userprofile == null)
                    {
                        // TempData["UsernameError"] = ViewBag.UsernameError;
                        return RedirectToAction("Profile");
                    }
                    else
                    {
                        return RedirectToAction("GeneralInfo");
                    }
                } 
                else 
                {
                    return View();
                }
            }
        }
        [HttpGet]
        [Route("/profile")]
        public IActionResult Profile() 
        {
            ViewBag.statuspage = "weight";
            return View("userprofile");
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
        //     User currentUser = _context.Users.SingleOrDefault(u => u.Id == userId);
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
        //     _context.SaveChanges();
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

        //     _context.Add(newPreference);
        //     _context.SaveChanges();
        //     return RedirectToAction("Dashboard");
        // }

        // [HttpGet]
        // [Route("/dashboard")]
        // public IActionResult Dashboard() {
        //     return View();
        // }

        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            int? userId = HttpContext.Session.GetInt32("currentUserId");
            if(userId == null)
            {
                TempData["LogErrors"] = "You need to log in first";
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
            else
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
        }


    }
}
