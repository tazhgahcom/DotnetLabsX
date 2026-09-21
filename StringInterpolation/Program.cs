int age = 33;

string ageText = age switch
{
    > 80 => "Old",
    > 60 => "Getting Old",
    > 20 => "A Good Age",
    _ => "Teenager"
};

Console.WriteLine($"The user is {age} years old, which is {ageText}");