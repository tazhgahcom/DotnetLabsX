using Tazhgah.DesignPatterns.Mediator.Interfaces;
using Tazhgah.DesignPatterns.Mediator.Members;
using Tazhgah.DesignPatters.Mediator;

namespace Tazhgah.DesignPatterns.Mediator
{
    public class ChatRoom : IChatMediator
    {
        protected readonly List<User> _users = new();

        public void AddUser(User user)
        {
            user.SetMediator(this);
            _users.Add(user);
        }

        public void Notify(User sender, Message message)
        {
            if (_users.Count > 0)
            {
                foreach (var user in _users)
                {
                    if (user != sender && message.Receiver == user)
                    {
                        user.Receive(user, message);
                    }
                }
            }
        }
    }
}
