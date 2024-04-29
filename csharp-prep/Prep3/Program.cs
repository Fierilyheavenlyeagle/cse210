using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        string userInput2;
        userInput2 = "yes";

        while (userInput2 == "yes")
        {
            int guessCount = 0;
            string response;
            response = "";

                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(0,11);

            while (response != "You guessed it!" )
            {
                Console.Write("What is your guess?");
                string userInput1 = Console.ReadLine();
                int guess = int.Parse(userInput1);
                guessCount++;

                if (guess == magicNumber)
                {
                    response = "You guessed it!";
                    Console.Write($"{response}");
                    Console.Write("Do you want to play again? (yes or not):");
                    userInput2 = Console.ReadLine();
                    
                }
                else if (guess < magicNumber)
                {
                    response = "greater";
                    Console.Write($"{response}, ");
                }
                else if (guess > magicNumber)
                {
                    response = "lower";
                    Console.Write($"{response}, ");
                }      
     
            }

            

        }   
    
    }

}