using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrookingsCommunity.Models;
using Microsoft.EntityFrameworkCore;

namespace BrookingsCommunity.Repos
{
    public class MessageRepo : IMessageRepo
    {
        private AppDbContext context;


        public List<Message> Messages { get { return context.Messages.Include("Replies").ToList(); } }
        public MessageRepo(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public void AddMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public void AddReply(Message message, Reply reply)
        {
            message.Replies.Add(reply);
            context.Messages.Update(message);
            context.SaveChanges();
        }
        public Message GetMessageBySender(string messageSender)
        {
            Message message = context.Messages.First(m => m.MessageSender == messageSender);
            return message;
        }

    }
}
