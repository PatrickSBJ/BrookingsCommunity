using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrookingsCommunity.Models;

namespace BrookingsCommunity.Repos
{
    public class MessageRepo : IMessageRepo
    {
        private static List<Message> messages = new List<Message>();

        public List<Message> Messages { get { return messages; } }
        public MessageRepo()
        {
           if (messages.Count == 0)
            {
                AddSeedData();
            }
        }
        public void AddMessage(Message message)
        {
            messages.Add(message);
        }
        public Message GetMessageBySender(string messageSender)
        {
            Message message = messages.Find(m => m.MessageSender == messageSender);
            return message;
        }
        void AddSeedData()
        {
            Message message = new Message()
            {
                MessageText = "New Message",
                MessageSender = "John",
                MessageReceiver = "Jane",
                MessagePriority = "text-danger",
            };

            Reply reply = new Reply()
            {
                ReplySender = "Jane",
                ReplyText = "Hello Hello",
            };
            message.Replies.Add(reply);
            messages.Add(message);

        }
    }
}
