using System;
using System.Collections.Generic;
using System.Text;
using Tazhgah.DesignPatterns.Observer.Interfaces;

namespace Tazhgah.DesignPatterns.Observer.UIComponents
{
    public class ScoreUI : IGameObserver
    {
        public void Update(NotifyArgs args)
        {
            Console.WriteLine($"ScoreUI updated: {args.Score}");
        }
    }
}
