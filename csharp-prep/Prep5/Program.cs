using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        DisplayMessage();
        string userName = GetUserName();
        int userNumber1 = FavoriteNumber();
        int squaredNumber = SquareNumber(userNumber1);
        DisplayMessage1(userName, squaredNumber);
        

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string GetUserName()
        {
            Console.WriteLine("Please enter your name:");
            string userName = Console.ReadLine();

            return userName;
        }

        int FavoriteNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            string userNumber = Console.ReadLine();

            int userNumber1 = int.Parse(userNumber);

            return userNumber1;
        }

        int SquareNumber(int userNumber1)
        {
            int squaredNumber = userNumber1 * userNumber1;

            return squaredNumber;
        }
        
        void DisplayMessage1(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

      

    }
}