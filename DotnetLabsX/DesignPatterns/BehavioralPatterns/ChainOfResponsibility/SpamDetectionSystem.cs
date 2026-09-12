using System;
using System.Collections.Generic;
using System.Text;
using Tazhgah.DesignPatterns.ChainOfResponsibility.SpamHandlers;

namespace Tazhgah.DesignPatterns.ChainOfResponsibility
{
    public class SpamDetectionSystem
    {
        protected readonly SpamHandler _chain = null!;

        public SpamDetectionSystem()
        {
            _chain = new BlacklistHandler();
            var keywordHandler = new KeywordHandler();
            var mlHandler = new MLHandler();

            _chain.SetSuccessor(keywordHandler);
            keywordHandler.SetSuccessor(mlHandler);
        }


        public bool CheckSpam(EmailMessage message)
        {
            if (_chain != null)
            {
                return _chain.HandleSpamCheck(message);
            }
            return false;
        }

    }
}
