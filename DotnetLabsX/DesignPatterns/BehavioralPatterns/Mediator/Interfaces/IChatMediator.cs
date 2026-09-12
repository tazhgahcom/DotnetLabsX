using Tazhgah.DesignPatterns.Mediator.Members;
using Tazhgah.DesignPatters.Mediator;

namespace Tazhgah.DesignPatterns.Mediator.Interfaces
{
    public interface IChatMediator
    {
        void Notify(User sender, Message message);
        void AddUser(User user);
    }
}
