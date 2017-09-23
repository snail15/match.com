using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace match.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/register")]
        public IActionResult Register(string name, string email, string password, string confirm){
            string _name = name;
            string _email = email;
            string _password = password;
            string _confirm = confirm;

            return RedirectToAction("Height");
        }

        [HttpGet]
        [Route("/height")]
        public IActionResult Height(){
            return View();
        }

        [HttpGet]
        [Route("/bodytype")]
        public IActionResult BodyType() {
            return View();
        }
    }
}
