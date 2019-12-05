using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrookingsCommunity.Models
{
    public class User
    {
        public int UserID { get; set; }

        private List<Message> messages = new List<Message>();
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Message> Messages {get { return messages; } }
    }
}
