using Tazhgah.DesignPatterns.Mediator.Interfaces;
using Tazhgah.DesignPatters.Mediator;

namespace Tazhgah.DesignPatterns.Mediator.Members
{
    public abstract class User
    {
        protected IChatMediator? _mediator;        
        public string Name { get; set; } = null!;
        public string Family { get; set; } = null!;
        public string Role { get; set; } = null!;

        public virtual void SetMediator(IChatMediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(Message message)
        {
            if (_mediator is not null)
            {
                _mediator.Notify(this, message);
            }
        }

        public void Receive(User sender, Message message)
        {
            Console.WriteLine($"I ({this.Name} {this.Family}) receive a message from ({message.Sender.Name} {message.Sender.Family})");
        }
    }
}
