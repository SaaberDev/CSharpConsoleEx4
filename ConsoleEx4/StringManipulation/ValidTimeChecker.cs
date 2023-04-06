namespace ConsoleEx4.StringManipulation;

public static class ValidTimeChecker
{
    public static void DisplayResult()
    {
        ASK_QUESTION:
        Console.WriteLine("Please Enter Time in 24 Hour Format. i.e. 22:59");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid Time Provided.");
            goto ASK_QUESTION;
        }

        // split the time
        var timeComponents = input.Split(":");

        if (timeComponents.Length != 2)
        {
            Console.WriteLine("Invalid Time Provided.");
            goto ASK_QUESTION;
        }

        // remove spaces from time components
        var leftString = timeComponents[0].Trim().Contains(" ")
            ? timeComponents[0].Trim().Replace(" ", "")
            : timeComponents[0].Trim();
        var rightString = timeComponents[1].Trim().Contains(" ")
            ? timeComponents[1].Trim().Replace(" ", "")
            : timeComponents[1].Trim();

        if (leftString.Length != 2 || rightString.Length != 2)
        {
            Console.WriteLine("Invalid Time Provided.");
            goto ASK_QUESTION;
        }

        // convert to int32
        var hour = Convert.ToInt32(leftString);
        var minute = Convert.ToInt32(rightString);
        if (hour is >= 0 and <= 23 && minute is >= 0 and <= 59)
        {
            Console.WriteLine("Okay");
        }
        else
        {
            Console.WriteLine("Invalid Time Provided.");
            goto ASK_QUESTION;
        }
    }
}