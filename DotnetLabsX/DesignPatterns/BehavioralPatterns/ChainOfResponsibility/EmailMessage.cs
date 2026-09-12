using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.DesignPatterns.ChainOfResponsibility
{
    public class EmailMessage
    {
        public int Id { get; set; }
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
        public string Sender { get; set; } = null!;
        public string Receiver { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
