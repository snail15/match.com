using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using match.Models;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.IO;
using Microsoft.Net.Http.Headers;

namespace match.Controllers
{
    public class HomeController : Controller
    {
        private MatchContext context;
        const int TRUE = 1;
        const int FALSE = 0;
        const int BUDDISHM = 1;
        const int CHRISTIANITY = 2;
        const int ISLAM = 3;
        const int RELIGION_OTHER = 4;
        const int ASIAN = 1;
        const int AFRICAN_AMERICAN = 2;
        const int WHITE = 3;
        const int LATINO = 4;
        const int ETHNICITY_OTHER = 5;
        const int MARRIED = 1;
        const int SEPERATED = 2;
        const int NEVER_MARRIED = 3;
        const int DIVORCED = 4;
        const int SLIM = 1;
        const int AVERAGE = 2;
        const int ABOVE_AVERAGE = 3;
        const int BIG = 4;


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
            
            if(ModelState.IsValid){
                User newUser = new User{
                    Name = model.Name,
                    Email = model.Email
                };
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.Password = hasher.HashPassword(newUser, model.Password);
                context.Add(newUser);
                context.SaveChanges();
                HttpContext.Session.SetInt32("currentUserId", newUser.Id);
                return RedirectToAction("GeneralInfo");
            } else {
                return View();
            }
           
        }


        [HttpGet]
        [Route("/generalinfo")]
        public IActionResult GeneralInfo() {
            return View();
        }

        [HttpPost]
        [Route("/generalinfo")]
        public IActionResult GeneralInfo(string month, string day, string year, string foot, string inch, string drink, string religion, string smoke, string ethnicity, string relationship, string kids, string minage, string maxage, string bodytype ) {

            if(month == "0" || day ==  "0" || year == "0" || foot == "0" || inch == "-1"){
                ViewBag.Error = "All Fields Are Required!";
                return View();
            }
            // Parsing relevant data
            string birthdayString = year + "," + month + "," + day;
            DateTime birthday = DateTime.Parse(birthdayString);
            TimeSpan ageNow = DateTime.Now - birthday;
            int age = (int)ageNow.TotalDays/365;
            int intFoot = Int32.Parse(foot);
            int intInch = Int32.Parse(inch);
            int height = (intFoot * 12) + intInch;
            int intDrink = Int32.Parse(drink);
            int intRelationship = Int32.Parse(relationship);
            int intSmoke = Int32.Parse(smoke);
            int intKids = Int32.Parse(kids);
            int intMinAge = Int32.Parse(minage);
            int intMaxAge = Int32.Parse(maxage);
            int intBodyType = Int32.Parse(bodytype);

            // Add data to the current user             
            int? userId = HttpContext.Session.GetInt32("currentUserId");
            User currentUser = context.Users.SingleOrDefault(u => u.Id == userId);
            currentUser.Age = age;
            currentUser.Birthday = birthday;
            currentUser.Height = height;
            currentUser.Drink = intDrink;
            currentUser.Relationship = intRelationship;
            currentUser.Smoke = intSmoke;
            currentUser.Kid = intKids;
            currentUser.MinAge = intMinAge;
            currentUser.MaxAge = intMaxAge;
            currentUser.BodyType = intBodyType;
            context.SaveChanges();
            return RedirectToAction("Preference");

        }

        [HttpGet]
        [Route("/preference")]
        public IActionResult Preference() {
            return View();
        }

        [HttpPost]
        [Route("/preference")]
        public IActionResult Preference(string smoke, string relationship, string drink, string religion, string bodytype, string ethnicity, string kid, string foot, string inch) {

            int? userId = HttpContext.Session.GetInt32("currentUserId");

            // Parse all the data
            int intSmoke = Int32.Parse(smoke);
            int intKid = Int32.Parse(kid);
            int intRelationship = Int32.Parse(relationship);
            int intDrink = Int32.Parse(drink);
            int intReligion = Int32.Parse(religion);
            int intEthnicity = Int32.Parse(ethnicity);
            int intBodyType = Int32.Parse(bodytype);
            int intFoot = Int32.Parse(foot);
            int intInch = Int32.Parse(inch);
            int height = (intFoot * 12) + intInch;

            Preference newPreference = new Preference {
                UserId = (int)userId,
                Smoke = intSmoke,
                Kid = intKid,
                Relationship = intRelationship,
                Drink = intDrink,
                Religion = intReligion,
                Ethnicity = intEthnicity,
                BodyType = intBodyType,
                Height = height

            };

            context.Add(newPreference);
            context.SaveChanges();
            return RedirectToAction("ProfilePic");
        }

        [HttpGet]
        [Route("/dashboard")]
        public IActionResult Dashboard() {
            int? userId = HttpContext.Session.GetInt32("currentUserId");
            User currentUser = context.Users.SingleOrDefault(u => u.Id == (int)userId);
            ViewBag.User = currentUser;
            return View();
        }

        [HttpGet]
        [Route("/login")]
        public IActionResult LogIn() {
            return View();
        }
        [HttpPost]
        [Route("/login")]
        public IActionResult LogIn(string email, string password) {
            if(email == null || password == null){
                ViewBag.Error = "All Fields Required!";
                return View();
            }
            User loginUser = context.Users.SingleOrDefault(u => u.Email == email);
            var Hasher = new PasswordHasher<User>();

               
            if(loginUser == null){
                ViewBag.UserError = "User does not exists";
            }

            if(0 == Hasher.VerifyHashedPassword(loginUser, loginUser.Password, password)) {
                ViewBag.PasswordError = "Wrong password";
            } else {
                  HttpContext.Session.SetInt32("currentUserId", loginUser.Id);
                  return RedirectToAction("Dashboard");
            }

            return View();
        }

        [HttpGet]
        [Route("/logout")]
        public IActionResult LogOut() {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("/profilepic")]
        public IActionResult ProfilePic(){
            return View();
        }

        [HttpPost]
        [Route("/profilepic")]
        public async Task<IActionResult> ProfilePic(IFormFile file){
            int? currentUserId = HttpContext.Session.GetInt32("currentUserId");
            User currentUser = context.Users.SingleOrDefault(user => user.Id == currentUserId);
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "wwwroot/profiles");
            var fileName = currentUser.Id + Path.GetExtension(file.FileName);
            currentUser.ImgUrl = "/profiles/" + fileName;
            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create)){
                Console.WriteLine("ready to save");
                await file.CopyToAsync(fileStream);
            }
            context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        // public List<User> GetMatching(Preference preference){
        //     int? currentUserId = HttpContext.Session.GetInt32("currentUserId");
        //     List<Preference> otherPreferences = new List<Preference>();
        //     if(preference.Ethnicity == 0 && preference.Religion == 0){
        //         otherPreferences = context.Preferences.Where(p => p.UserId != currentUserId
        //         && p.Kid == preference.Kid && p.Drink == preference.Drink).ToList();
        //     }
        //     if(preference.Ethnicity == 0){
        //         otherPreferences = context.Preferences.Where();
        //     } else if(preference.Religion == 0){
        //         otherPreferences = context.Preferences.Where();
        //     } else {
        //         otherPreferences = context.Preferences.Where();
        //     }

        //     int score = 0;
        //     Dictionary<int, int> matchingUsers = new Dictionary<int, int>();
        //     foreach (var user in otherPreferences) {

        //     }



        //     return matchings;

        // }

    }
}
