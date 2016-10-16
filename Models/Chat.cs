﻿using System.Collections.Generic;

namespace SignalRChat.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Message> Messages { get; set; }

        public virtual List<User> Users { get; set; } 
    }
}