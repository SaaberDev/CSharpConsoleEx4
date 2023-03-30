namespace ConsoleEx4.StringManipulation;

public static class NumberSerialChecker
{
    public static void DisplayResult()
    {
        Console.WriteLine("Please enter a few numbers separated by a hyphen. i.e. 1-2-3-4-5");
        var input = Console.ReadLine();
        
        var numbers = new List<int>();
        
        if (input != null)
        {
            foreach (var value in input.Split("-"))
            {
                numbers.Add(Convert.ToInt32(value));
            }
        }

        // sort is used to move the first number as last.
        // index start from 1.
        // we cannot start index from zero due to we don't have "-1" as index while checking the same value of index number in the below loop
        numbers.Sort();

        var isConsecutive = true;
        for (var i = 1; i < numbers.Count; i++)
        {
            // here we are checking if value of index "1" is equal to value of index "1"
            if (numbers[i] == numbers[i - 1] + 1) continue;
            isConsecutive = false;
            break;
        }

        var message = isConsecutive ? "Consecutive" : "Not Consecutive";
        Console.WriteLine(message);
    }
}