namespace ConsoleEx4.StringManipulation;

public static class ConvertStringToPascalCase
{
    public static void DisplayResult()
    {
        Console.WriteLine(UpperCaseFirst("please enter a few words sepaRated by a space. i.e. "));
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("You did not provided anything. Exiting ...");
            return;
        }

        Console.WriteLine(UpperCaseFirst(input).Replace(" ", ""));
    }

    private static string UpperCaseFirst(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }
        
        // turn all character into an array from value
        var array = value.ToCharArray();

        /*
         * STEP :: 1
         *
         * turn first character to uppercase
         */
        if (array.Length >= 1)
        {
            if (char.IsLower(array[0]))
            {
                array[0] = char.ToUpper(array[0]);
            }
        }
        
        /*
         * STEP :: 2
         * 
         * Scan all characters by index and find if previous character of that index has a space or empty character.
         * If found space turn that index uppercase else lowercase.
         */
        for (var i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == ' ')
            {
                if (char.IsLower(array[i]))
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }
            else
            {
                array[i] = char.ToLower(array[i]);
            }
        }
        
        return new string(array);
    }
}