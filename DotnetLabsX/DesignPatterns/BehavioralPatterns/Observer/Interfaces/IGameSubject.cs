using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.DesignPatterns.Observer.Interfaces
{
    public interface IGameSubject
    {
        void Notify();
        void Attach(IGameObserver observer);
        void Detach(IGameObserver observer);
    }
}
