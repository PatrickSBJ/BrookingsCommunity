﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrookingsCommunity.Models
{
    public class Message
    {
        public string MessageText { get; set; }
        public User MessageSender { get; set; }
        public User MessageReceiver { get; set; }
    }
}
