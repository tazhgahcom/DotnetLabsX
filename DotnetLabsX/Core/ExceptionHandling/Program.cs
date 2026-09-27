
using Tazhgah.Core.ExceptionHandling;

int userAge = 0;

try
{
    userAge = Utils.GetAge("test");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
    throw;
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

Console.WriteLine($"Your age is: {userAge}");