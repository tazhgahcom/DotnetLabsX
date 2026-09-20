//object myName = "Siavash Ebrahimi";
//object myAge = 30;

//if (myName is string value)
//{
//    WriteLine(value);
//}

//if (myAge is int myAgeValue && myAgeValue >= 30)
//{
//    WriteLine("You are above 30 years old");
//}
//else
//{
//    WriteLine("You are under 30 years old");
//}


//object userEnteredValue = 1.22f;
//switch (userEnteredValue)
//{
//    case int number:
//        WriteLine($"Integer Value: {number}");
//        break;
//    case string text:
//        WriteLine($"String Value: {text}");
//        break;
//    case float floatNumber:
//        WriteLine($"Float Value: {floatNumber}");
//        break;
//    default:
//        WriteLine("Unknown type");
//        break;
//}


//object value = "Siavash Ebrahimi";
//string result = value switch
//{
//    int number => $"Integer Value: {number}",
//    string text => $"String Value: {text}",
//    _ => "Unknown Type"
//};

//WriteLine(result);

//int userAge = 64;
//string message = userAge switch
//{
//    0 => "Newborn",
//    < 18 => "Minor",
//    >= 18 and <= 60 => "Adult",
//    > 60 => "Senior"
//};

//WriteLine(message);

//string name = "younes";
//string family = name.ToLower() switch
//{
//    "siavash" => "ebrahimi",
//    "soroush" => "ebrahimi",
//    "younes" => "ebrahimi",
//    "yahya" => "ebrahimi",
//    _ => "Unknown family"
//};

//WriteLine($"{name} {family}");

PersonModel pm = new()
{
    Id = 1,
    Name = "Siavash",
    Family = "Ebrahimi",
    Address = new() { City = "Kouhdasht", State = "Lorestan" }
};

if (pm is { Name: "Siavash", Address.City: "Kouhdasht" })
{
    WriteLine("Siavash Found !");
}

if (pm is { Name: "Siavash" })
{
    WriteLine("Match");
}