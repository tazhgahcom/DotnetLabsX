using Tazhgah.DesignPatterns.Observer;
using Tazhgah.DesignPatterns.Observer.UIComponents;

var subject = new Player();
subject.Name = "Siavash Ebrahimi";
subject.Score = 0;

subject.Attach(new HealthBarUI());
subject.Attach(new GameOverUI());
subject.Attach(new ScoreUI());

subject.SetState("State 1");
await Task.Delay(1500);
Console.WriteLine("=============");
subject.SetState("State 2");