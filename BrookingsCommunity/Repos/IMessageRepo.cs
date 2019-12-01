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
        Message GetMessageBySender(string messageSender);
    }
}
