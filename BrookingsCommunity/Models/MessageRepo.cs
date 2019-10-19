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
        public static void AddMessage(Message message)
        {
            messages.Add(message);
        }
    }
}
