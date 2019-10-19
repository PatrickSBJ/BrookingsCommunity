using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BrookingsCommunity.Models;
using System.Collections.Generic;

namespace BrookingsCommunity.Controllers
{
    public class HomeController : Controller
    {
        Message message;
        User John = new User()
        {
            Name = "John",
            Email = "John@gmail.com"
        };
        User Jane = new User()
        {
            Name = "Jane",
            Email = "Jane@gmail.com"
        };


        public HomeController()
        {
            if (MessageRepo.Messages.Count == 0) 
            {
                message = new Message()
                {
                    MessageSender = John,
                    MessageReceiver = Jane,
                    MessageText = "Hello"
                };
                MessageRepo.AddMessage(message);
            }
            if(UserDirectory.Users.Count == 0)
            {
                UserDirectory.AddUser(John);
                UserDirectory.AddUser(Jane);
            }
        }
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult MessageList()
        {
            List<Message> messages = MessageRepo.Messages;
            return View(messages);
        }
        public ViewResult HistoryPage()
        {
            return View();
        }
        public ViewResult ContactPage()
        {
            List<User> users = UserDirectory.Users;
            return View(users);
        }
        public ViewResult InfoPage()
        {
            return View();
        }
        public ViewResult LocationsPage()
        {
            return View();
        }
        public ViewResult PeoplePage()
        {
            return View();
        }
        [HttpPost]
        public RedirectToActionResult ContactPage(User messageSender,
                                      User messageReceiver, string messageText)
        {
            message = new Message();
            message.MessageSender = messageSender;
            message.MessageReceiver = messageReceiver;
            message.MessageText = messageText;
            MessageRepo.AddMessage(message); 

            return RedirectToAction("ContactPage");
        }
    }
}
