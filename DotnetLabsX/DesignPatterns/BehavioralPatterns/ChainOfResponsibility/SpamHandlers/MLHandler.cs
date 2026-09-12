namespace Tazhgah.DesignPatterns.ChainOfResponsibility.SpamHandlers
{
    public class MLHandler : SpamHandler
    {
        public override bool HandleSpamCheck(EmailMessage message)
        {

            Console.WriteLine("Check email message in BlacklistHandler");

            if (message.Subject == null)
            {
                return false;
            }

            if ((bool)(message.Subject.Contains("siavash")))
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
