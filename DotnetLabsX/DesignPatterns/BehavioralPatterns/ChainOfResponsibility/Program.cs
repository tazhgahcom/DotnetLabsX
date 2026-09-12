using Tazhgah.DesignPatterns.ChainOfResponsibility;


var sds = new SpamDetectionSystem();
var emailMessage = new EmailMessage()
{
    Id = 1,
    Subject = "CSharp Programming Language",
    Body = "This is a course about csharp programming language",
    Sender = "tazhgah@gmail.com",
    Receiver = "tazhgahcom@gmail.com"
};

bool IsSpam = sds.CheckSpam(emailMessage);

if (IsSpam)
{
    Console.WriteLine("Spam ...");
}
else
{
    Console.WriteLine("Not Spam ...");
}