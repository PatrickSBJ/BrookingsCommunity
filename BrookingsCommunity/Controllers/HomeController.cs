using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BrookingsCommunity.Models;
using System.Collections.Generic;
using System.Web;
using BrookingsCommunity.Repos;


namespace BrookingsCommunity.Controllers
{
    public class HomeController : Controller
    {
        IMessageRepo repo;
        

        ImportantLocation location1;
        ImportantPerson person1;

        User john = new User()
        {
            Name = "John",
            Email = "eh@gmail.com",
        };
        User jane = new User()
        {
            Name = "Jane",
            Email = "ha@gmail.com",
        };
        
        

        public HomeController(IMessageRepo r)
        {
            repo = r;

            if (ImportantLocationRepo.Locations.Count == 0)
            {
                location1 = new ImportantLocation()
                {
                    Name = "Chetco Point",
                    Significance = "Scenic ocean overlook.",
                    LinkToInfo = "https://www.brookings.or.us/Facilities/Facility/Details/Chetco-Point-Park-6"

                };
                ImportantLocationRepo.AddLocation(location1);
            }

            if (ImportantPeopleRepo.People.Count == 0)
            {
                person1 = new ImportantPerson()
                {
                    Name = "Jaoe Teka",
                    Achievements = "Founder of the city.",
                    LinkToInfo = "https://www.dictionary.com/browse/person"
                };
                ImportantPeopleRepo.AddImportantPerson(person1);
            }
            if (UserDirectory.Users.Count == 0)
            {
                UserDirectory.AddUser(john);
                UserDirectory.AddUser(jane);
            }

        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult MessageList()
        {
            List<Message> messages = repo.Messages;
            messages.Sort((m1, m2) => DateTime.Compare(m1.DateCreated, m2.DateCreated));
            ViewBag.messageCount = messages.Count; 
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
            List<ImportantLocation> locations = ImportantLocationRepo.Locations;
            return View(locations);
        }
        public ViewResult PeoplePage()
        {
            List<ImportantPerson> people = ImportantPeopleRepo.People;
           return View(people);
        }
        [HttpPost]
        public RedirectToActionResult ContactPage(string messageSender,
                                      string messageReceiver, string messageText, string messagePriority)
        {
            Message message = new Message();
            message.MessageSender = messageSender;
            message.MessageReceiver = messageReceiver;
            message.MessageText = messageText;
            message.DateCreated = DateTime.Now;
            message.MessagePriority = messagePriority;
            repo.AddMessage(message); 

            return RedirectToAction("ContactPage");
        }
        public IActionResult AddReply(string messageSender)
        {
            return View("AddReply", HttpUtility.HtmlDecode(messageSender));
        }
        [HttpPost]
        public RedirectToActionResult AddReply(string messageSender, string replyText, string replySender)
        {
            Message message = repo.GetMessageBySender(messageSender);
            repo.AddReply(message,
                new Reply()
                {
                    ReplySender = replySender,
                    ReplyText = replyText,
                });
            return RedirectToAction("MessageList");
        }
    }
}
