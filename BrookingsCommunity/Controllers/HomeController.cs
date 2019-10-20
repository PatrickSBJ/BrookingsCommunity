using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using BrookingsCommunity.Models;
using System.Collections.Generic;
using System.Web;


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
        ImportantLocation location1;
        ImportantPerson person1;
        



        public HomeController()
        {
            if (MessageRepo.Messages.Count == 0) 
            {
                message = new Message()
                {
                    MessageSender = "John",
                    MessageReceiver = "Jane",
                    MessageText = "Sent from the beginning of time",
                    DateCreated = DateTime.MinValue
                };
                MessageRepo.AddMessage(message);
            }

            if(UserDirectory.Users.Count == 0)
            {
                UserDirectory.AddUser(John);
                UserDirectory.AddUser(Jane);
            }

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

        }
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult MessageList()
        {
            List<Message> messages = MessageRepo.Messages;
            messages.Sort((m1, m2) => DateTime.Compare(m1.DateCreated, m2.DateCreated));
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
            message = new Message();
            message.MessageSender = messageSender;
            message.MessageReceiver = messageReceiver;
            message.MessageText = messageText;
            message.DateCreated = DateTime.Now;
            message.MessagePriority = messagePriority;
            MessageRepo.AddMessage(message); 

            return RedirectToAction("ContactPage");
        }
        public IActionResult AddReply(string messageReceiver)
        {
            return View("AddReply", HttpUtility.HtmlDecode(messageReceiver));
        }
        [HttpPost]
        public RedirectToActionResult AddReply(string messageSender,
                                                string replyText,
                                                string replySender)
        {
            Message message = MessageRepo.GeMessageBySender(messageSender);
            message.Replies.Add(new Reply()
            {
                ReplySender = new User() { Name = replySender },
                ReplyText = replyText
            });
            return RedirectToAction("MessageList");
        }
    }
}
