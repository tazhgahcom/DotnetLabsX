//List<int> ages = [33, 34, 45, 49];
//List<string> names = ["siavash", "soroush", "younes", "yahya"];

//Console.WriteLine($"{names[0]} age: {ages[0]}");
//Console.WriteLine($"{names[1]} age: {ages[1]}");

using Dumpify;
using System.Diagnostics;
using Tazhgah.Core.Generics;

//List<int> numbers = [];
//List<object> objects = [];

//Stopwatch sw = new();
//sw.Start();
//for (int i = 0;i < 1_000_000; i++)
//{
//    numbers.Add(i);
//}
//sw.Stop();
//Console.WriteLine($"Add items to numbers: {sw.ElapsedMilliseconds}");


//sw = new();
//sw.Start();
//for(int i = 0; i < 1_000_000;i++)
//{
//    objects.Add(i);
//}
//sw.Stop();

//Console.WriteLine($"Add items to objecsts: {sw.ElapsedMilliseconds}");

//void TypeChecker<T>(T value) where T : UserRecord 
//{
//    Console.WriteLine("===============");
//    Console.WriteLine(typeof(T));
//    value.Dump();
//    Console.WriteLine("===============");
//}

//var user1 = new UserRecord("tazhgahcom", "pass123", "Siavash", "Ebrahimi");
//var user2 = new UserRecord("tazhgahcom", "pass123", "Siavash", "Ebrahimi");

//if (user1 == user2)
//{
//    Console.WriteLine("Equal");
//}
//else
//{
//    Console.WriteLine("Not Equal");
//}

////TypeChecker(new PersonRecord("Siavash", "Ebrahimi"));
//TypeChecker(new UserRecord("tazhgahcom", "pass123", "Siavash", "Ebrahimi"));
//TypeChecker(new UserRecord("takkhalcom", "pass1234", "Younes", "Ebrahimi"));


BetterList<UserRecord> listOfUsers = new();
listOfUsers.AddToList(new("tazhgahcom", "pass123", "Siavash", "Ebrahimi"));
listOfUsers.AddToList(new("takkhalcom", "pass123", "Siavash", "Ebrahimi"));
listOfUsers.PrintData();

record PersonRecord(string FirstName, string LastName);
record UserRecord(string Username, string Password, string FirstName, string LastName);