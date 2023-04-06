using ConsoleEx4.StringManipulation;

namespace ConsoleEx4.Init;

public static class InitProgram
{
    private static readonly string[] Names =
    {
        "Number Serial Checker",
        "Check And Display Duplicates",
        "Valid Time Checker",
        "Convert String To PascalCase",
        "Vowel Detector"
    };

    public static void DisplayNames()
    {
        var i = 1;
        foreach (var name in Names)
        {
            Console.WriteLine(i + ". " + name);
            i++;
        }
    }

    public static void Init()
    {
        Console.WriteLine("Please choose a program between 1 and 5.");
        var program = Convert.ToInt16(Console.ReadLine());

        switch (program)
        {
            case 1:
                Console.WriteLine("=============================");
                Console.WriteLine(Names[0]);

                NumberSerialChecker.DisplayResult();
                break;

            case 2:
                Console.WriteLine("=============================");
                Console.WriteLine(Names[1]);

                CheckAndDisplayDuplicates.DisplayResult();
                break;

            case 3:
                Console.WriteLine("=============================");
                Console.WriteLine(Names[2]);

                ValidTimeChecker.DisplayResult();
                break;

            case 4:
                Console.WriteLine("=============================");
                Console.WriteLine(Names[3]);

                ConvertStringToPascalCase.DisplayResult();
                break;

            case 5:
                Console.WriteLine("=============================");
                Console.WriteLine(Names[4]);

                VowelDetector.DisplayResult();
                break;

            default:
                Console.WriteLine("You did not choose any program.");
                break;
        }
    }
}