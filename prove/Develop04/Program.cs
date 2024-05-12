using System;

class Program
{
    static void Main(string[] args)
    {
        string scripture = "Porque el Espíritu Santo os enseñará en la misma hora lo que debáis decir.";
        string displayText = "";

        Console.WriteLine(scripture);
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        string userInput = Console.ReadLine();

        while (userInput != "quit")
        {
            displayText = HideAndDisplay(scripture, displayText);
            Console.WriteLine(displayText);
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
        }

        Console.WriteLine("Program Finished");
    }

    public static string HideAndDisplay(string scripture, string previousDisplayText = "")
    {
        string[] words = scripture.Split(' ');

        // If there is no previous display text, initialize it as the original scripture
        if (previousDisplayText == "")
        {
            previousDisplayText = scripture;
        }

        string[] previousWords = previousDisplayText.Split(' ');

        // Preserve hidden words or hide new words
        for (int i = 0; i < words.Length; i++)
        {
            if (previousWords[i] == new string('*', words[i].Length))
            {
                // Preserve previously hidden word
                words[i] = new string('*', words[i].Length);
            }
            else
            {
                // Hide new word
                words[i] = new string('*', words[i].Length);
            }
        }

        // Reconstruct modified scripture
        string modifiedScripture = string.Join(" ", words);

        return modifiedScripture;
    }
}
