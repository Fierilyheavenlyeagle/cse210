using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello cse210 World!");

        Console.Write("What is your name?");
        string name = Console.ReadLine();

        Console.Write("What is your last name?");
        string lastname = Console.ReadLine();
        
        Console.Write($"Your name is {lastname} , {name} {lastname}.");
       

    }
}