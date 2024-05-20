using System;

class Program
{
    static void Main()
    {
        string input = "First line\nSecond line\nThird line\nFourth line\nFourth line";
        string[] lines = input.Split('\n');

        // Make sure there are at least 3 lines
        if (lines.Length >= 3)
        {
            // Join the first three lines with newline characters
            string result = string.Join("\n", lines.Take(3));

            // Print or use the result as needed
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Input has less than 3 lines.");
        }
    }
}
