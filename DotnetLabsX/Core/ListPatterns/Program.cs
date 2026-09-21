string csv = "Siavash, Ebrahimi, 33, Yadollah";
string[] info = csv.Split(",");

Console.WriteLine(csv);
if (info is [var firstName, var lastName, ..])
{
    Console.WriteLine($"{firstName} {lastName}");
}