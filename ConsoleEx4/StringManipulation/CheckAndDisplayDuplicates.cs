namespace ConsoleEx4.StringManipulation;

public static class CheckAndDisplayDuplicates
{
    public static void DisplayResult()
    {
        Console.WriteLine("Please enter a few numbers separated by a hyphen. i.e. 1-2-3-4-5-1");
        var input = Console.ReadLine();

        var numbers = new List<int>();

        if (!string.IsNullOrWhiteSpace(input))
        {
            foreach (var value in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(value));
            }
        }

        /*
         * BLOCK :: 1
         */
        var uniques = new List<int>();
        var includesDuplicate = false;

        foreach (var number in numbers)
        {
            if (!uniques.Contains(number))
            {
                uniques.Add(number);
            }
            else
            {
                includesDuplicate = true;
                break;
            }
        }
        
        var message = includesDuplicate ? "Duplicate" : "";
        Console.WriteLine(message);
        
        /*
         * BLOCK :: 2
         */
        // EXTRA :: this block of code filter out the numbers that are duplicate and display in console
        
        /*var duplicates = new List<int>();

        var myCount = numbers.Count;
        for (var i = 0; i < myCount - 1; i++)
        {
            for (var j = i + 1; j < myCount; j++)
            {
                if (numbers[i] != numbers[j]) continue;
                if (!duplicates.Contains(numbers[i]))
                {
                    duplicates.Add(numbers[i]);
                }
            }
        }

        Console.WriteLine($"The duplicate numbers are: {string.Join(",", duplicates)}");*/
    }
    
}