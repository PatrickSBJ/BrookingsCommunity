using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrookingsCommunity.Models
{
    public class MessageRepo
    {
        private static List<Message> messages = new List<Message>();

        public static List<Message> Messages { get { return messages; } }
        static MessageRepo()
        {
          //  AddTestData();
        }
        public static void AddMessage(Message message)
        {
            messages.Add(message);
        }
        public static Message GetMessageBySender(string messageSender)
        {
            Message message = messages.Find(m => m.MessageSender == messageSender);
            return message;
        }
    }
}
