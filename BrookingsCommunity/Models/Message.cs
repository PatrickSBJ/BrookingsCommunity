using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrookingsCommunity.Models
{
    public class Message
    {
        private List<Reply> replies = new List<Reply>();

        public string MessageText { get; set; }
        public String MessageSender { get; set; }
        public String MessageReceiver { get; set; }
        public DateTime DateCreated { get; set; } 
        public string MessagePriority { get; set; }
        public List<Reply> Replies { get { return replies; } }
        
    }
}
