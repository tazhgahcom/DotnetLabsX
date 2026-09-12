using System;
using System.Collections.Generic;
using System.Text;
using Tazhgah.DesignPatterns.Mediator.Members;

namespace Tazhgah.DesignPatters.Mediator
{
    public class Message
    {
        public int Id { get; set; }
        public User Sender { get; set; } = null!;
        public User Receiver { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
