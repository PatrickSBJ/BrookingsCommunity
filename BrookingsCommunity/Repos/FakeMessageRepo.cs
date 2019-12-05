using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrookingsCommunity.Models;

namespace BrookingsCommunity.Repos
{
    public class FakeMessageRepo : IMessageRepo
    {
        private List<Message> messages = new List<Message>();

        public List<Message> Messages { get { return messages; } }
        public  void AddMessage(Message message)
        {
            messages.Add(message);
        }

        public void AddReply(Message message, Reply reply)
        {
            throw new NotImplementedException();
        }

        public Message GetMessageBySender(string messageSender)
        {
            Message message = messages.Find(m => m.MessageSender == messageSender);
            return message;
        }
    }
}
