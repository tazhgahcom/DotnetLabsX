using System;
using System.Collections.Generic;
using System.Text;

namespace Tazhgah.DesignPatterns.Observer.Interfaces
{
    public interface IGameObserver
    {
        void Update(NotifyArgs args);
    }
}
