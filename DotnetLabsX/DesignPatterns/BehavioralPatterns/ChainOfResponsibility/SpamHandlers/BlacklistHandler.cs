
namespace Tazhgah.DesignPatterns.ChainOfResponsibility.SpamHandlers
{
    public class BlacklistHandler : SpamHandler
    {

        protected readonly List<string> _blockedUsers = new() { "vbnetgenius@gmail.com", "tazhgah@gmail.com" };

        public override bool HandleSpamCheck(EmailMessage message)
        {
            Console.WriteLine("Check email message in BlacklistHandler");
                
            if (_blockedUsers.Contains(message.Sender?.ToLower(), StringComparer.OrdinalIgnoreCase))
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
