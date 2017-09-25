using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using match.Models;
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
// =============================================================
// =============================================================

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
// =============================================================
// =============================================================
        [HttpPost]
        [Route("/register")]
        public IActionResult Register(string name, string email, string password, string confirm){
            string _name = name;
            string _email = email;
            string _password = password;
            string _confirm = confirm;

            return RedirectToAction("Height");
        }
// =============================================================
// =============================================================

        [HttpGet]
        [Route("/height")]
        public IActionResult Height(){
            return View();
        }
// =============================================================
// =============================================================

        [HttpGet]
        [Route("/bodytype")]
        public IActionResult BodyType() {
            return View();
        }
// =============================================================
// =============================================================
        [HttpPost]
        [Route("/sendMessage")]
        public IActionResult sendMessage(MessageViewModel model) 
        {
             int? userId = HttpContext.Session.GetInt32("currentUserId");
            
            User currentUser = context.Users.SingleOrDefault(user => user.Id == userId);

            if(ModelState.IsValid)
            {
                Message newMessage = new Message 
                {
                    messageContent = model.messageContent,
                    senderId = currentUser.Id,
                    receiverId = ,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                context.Add(newMessage);
                context.SaveChanges();
                return RedirectToAction("dashBoard");
            } 
            else
            {
                ViewBag.User = currentUser;
                
                return View(model);
            }

            return View(model);
        }
// =============================================================
// =============================================================
        
    }
}
