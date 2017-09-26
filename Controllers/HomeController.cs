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
            
            User currentUser = context.Users.SingleOrDefault(user => user.id == userId);

            if(ModelState.IsValid)
            {
                Message newMessage = new Message 
                {
                    messageContent = model.messageContent,
                    senderId = currentUser.id,
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
        [HttpPost]
        [Route("/reply")]
        public IActionResult Reply(ReplyViewModel model, int message_Id) 
        {
            int? userId = HttpContext.Session.GetInt32("currentUserId");
            
            User currentUser = context.Users.SingleOrDefault(user => user.id == userId);

            if(ModelState.IsValid)
            {
                Reply newReply = new Reply 
                {
                    replyContent = model.replyContent,
                    senderId = currentUser.id,
                    messageId = message_Id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                context.Add(newReply);
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
        [HttpGet]
        [Route("messages/Inbox")]
        public IActionResult Inbox()
        { DateTime CurrentTime = DateTime.Now;

            int? userId = HttpContext.Session.GetInt32("currentUserId");
            User currentUser = context.Users.SingleOrDefault(user => user.id == userId);

            List<Message> allMessages = context.Messages.OrderBy(message => message.created_at).Where(message => message.receiverId == currentUser.id).ToList();

            foreach(var message in allMessages)
                {

                    User sender = context.Users.SingleOrDefault(user => user.id == message.senderId);
                   
                }

            context.SaveChanges();

            ViewBag.User = currentUser;
            ViewBag.Messages = allMessages;
            return View();
        }
// =============================================================
// =============================================================

        [HttpGet]
        [Route("messages/Sent")]
        public IActionResult Sent()
        { DateTime CurrentTime = DateTime.Now;

            int? userId = HttpContext.Session.GetInt32("currentUserId");
            User currentUser = context.Users.SingleOrDefault(user => user.id == userId);

            List<Message> allMessages = context.Messages.OrderBy(message => message.created_at).Where(message => message.senderId == currentUser.id).ToList();

            // foreach(var message in allMessages)
            //     {

            //         User receiver = context.Users.SingleOrDefault(user => user.id == message.senderId);
                   
            //     }

            context.SaveChanges();

            ViewBag.User = currentUser;
            ViewBag.Messages = allMessages;
            return View();
        }
// =============================================================
// =============================================================
        [HttpGet]
        [Route("/message/{id}")]
        public IActionResult viewMessage(string id)
        {
            int? userId = HttpContext.Session.GetInt32("currentUserId");
            User currentUser = context.Users.SingleOrDefault(user => user.id == userId);
            
            int messageId = Int32.Parse(id);
            Message showingMessage = context.Messages.SingleOrDefault(message => message.Id == messageId);
            ViewBag.Messages = showingMessage;
            ViewBag.User = currentUser;
            return View();
        }
// =============================================================
// =============================================================
        [HttpGet]
        [Route("/message/delete/{id}")]
        public IActionResult DeleteMessage(string id)
        {
            int messageId = Int32.Parse(id);
            Message deletedMessage = context.Messages.SingleOrDefault(message => message.Id == messageId);
            context.Messages.Remove(deletedMessage);
            context.SaveChanges();

            return RedirectToAction("Inbox");
        }
// ========================================================================================
// ========================================================================================  
        
        [HttpGet]
        [Route("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
// ========================================================================================
// ========================================================================================
    }
}
