using System;
using System.Runtime.CompilerServices;
using Tazhgah.Core.Tuples;

public class Program
{
    static void Main(string[] args)
    {
        try
        {

            (string helloMessage, int helloMessageLength) = SayHello("Siavash", "Ebrahimi");
            WriteLine(helloMessage);
            WriteLine(helloMessageLength);

            (bool isValid, string firstName, string lastName) = SplitName("siavash ebrahimi");
            if (isValid)
            {
                ConsoleMessage.WriteSuccessMessage("Valid");
            }
            else
            {
                ConsoleMessage.WriteErrorMessage("Not Valid");
            }
        }
        catch (Exception ex)
        {
            ConsoleMessage.WriteErrorMessage(ex.Message);
        }
    }

    static (string formattedAddress, bool isValid) FormatAddress(string message)
    {
        if (message is not null && message.ToLower().Contains("tehran"))
        {
            return ("Tehran", true);
        }
        return ("", false);
    }

    static (bool, string, string) SplitName(string fullname)
    {

        ArgumentNullException.ThrowIfNullOrEmpty(fullname);

        if (fullname is null)
        {
            return (false, "", "");
        }

        if (fullname.Trim().Length == 0)
        {
            return (false, "", "");
        }

        if (fullname.IndexOf(' ') < 0)
        {
            return (false, "", "");
        }

        var explodedName = fullname.Split(' ');

        return (true, explodedName[0], explodedName[1]);
    }


    static (string message, int length) SayHello(string firstName, string lastName)
    {
        string output = $"Hello {firstName} {lastName}";
        return (output, output.Length);
    }

}