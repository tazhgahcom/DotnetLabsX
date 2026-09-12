using Tazhgah.DesignPatterns.Mediator;
using Tazhgah.DesignPatterns.Mediator.Interfaces;
using Tazhgah.DesignPatterns.Mediator.Members;
using Tazhgah.DesignPatters.Mediator;


var userSiavash = new AdminUser()
{
    Name = "Siavash",
    Family = "Ebrahimi",
    Role = "admin"
};

var userMohammad = new AdminUser()
{
    Name = "Mohammad",
    Family = "Rostamdar",
    Role
    = "subscriber"
};
var userBehzad = new AdminUser()
{
    Name = "Behzad",
    Family = "Fattahi",
    Role = "subscriber"
};

IChatMediator mediator = new ChatRoom();
mediator.AddUser(userSiavash);
mediator.AddUser(userMohammad);
mediator.AddUser(userBehzad);

var message = new Message()
{
    Id = 1,
    Sender = userSiavash,
    Receiver = userMohammad,
    Text = "Hello !"
};

userSiavash.Send(message);
Console.WriteLine("=================");
userBehzad.Send(new Message()
{
    Id = 2,
    Sender = userBehzad,
    Receiver = userSiavash,
    Text = "Salam Siavash"
});

