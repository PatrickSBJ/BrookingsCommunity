using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrookingsCommunity.Models;

namespace BrookingsCommunity.Repos
{
    public interface IMessageRepo
    {
        List<Message> Messages { get; }
        void AddMessage(Message message);
        void AddReply(Message message, Reply reply);

        Message GetMessageBySender(string messageSender);
    }
}
