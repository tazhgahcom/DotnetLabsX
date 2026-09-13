using System;
using System.Collections.Generic;
using System.Text;
using Tazhgah.DesignPatterns.Observer.Interfaces;

namespace Tazhgah.DesignPatterns.Observer.UIComponents
{
    public class GameOverUI : IGameObserver
    {
        public void Update(NotifyArgs args)
        {
            if (args.IsDead)
            {
                Console.WriteLine("Game Over ...");
            }
        }
    }
}
