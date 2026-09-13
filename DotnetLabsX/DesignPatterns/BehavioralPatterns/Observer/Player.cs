using Tazhgah.DesignPatterns.Observer.Interfaces;

namespace Tazhgah.DesignPatterns.Observer
{
    public class Player : IGameSubject
    {

        protected string _state = "";
        protected readonly List<IGameObserver> _observers = [];

        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsDead {
            get => Score <= 0;
        }

        public void Attach(IGameObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IGameObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in _observers)
            {                
                observer.Update(new NotifyArgs(_state, Name, Score, IsDead));
            }
        }

        public void SetState(string newState)
        {
            _state = newState;
            Notify();
        }
        public string GetState() => _state;

    }
}
