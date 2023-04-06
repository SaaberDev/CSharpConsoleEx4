namespace ConsoleEx4.StringManipulation;

public static class VowelDetector
{
    public static void DisplayResult()
    {
        ASK_QUESTION:
        Console.WriteLine("Please enter an English word.");
        var input = Console.ReadLine();
        var vowels = new List<char>(new[] { 'a', 'e', 'i', 'o', 'u' });

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Empty value is not allowed.");
            goto ASK_QUESTION;
        }

        var characters = input.ToLower();

        var countVowels = 0;

        foreach (var character in characters)
        {
            if (vowels.Contains(character))
            {
                countVowels++;
            }
        }

        Console.WriteLine(countVowels);
    }
}