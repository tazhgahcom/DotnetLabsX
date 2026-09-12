using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.DesignPatterns.ChainOfResponsibility.SpamHandlers
{
    public class KeywordHandler : SpamHandler
    {
        protected readonly List<string> _invalidKeywords = new() { "siavash", "ebrahimi" };

        public override bool HandleSpamCheck(EmailMessage message)
        {
            Console.WriteLine("Check email message in KeywordHandler");
            if (
                _invalidKeywords.Contains(message.Subject.ToLower()) ||
                _invalidKeywords.Contains(message.Body.ToLower())
                )
            {
                return true;
            }
            
            if (_successor is not null)
            {
                return _successor.HandleSpamCheck(message);
            }

            return false;
        }
    }
}
