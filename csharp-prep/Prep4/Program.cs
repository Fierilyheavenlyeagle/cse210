using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        string userInput;
        userInput = "";

        List<int> numbers= new List<int>();

        while (userInput != "0" )
        {
            Console.WriteLine("Enter a number: ");
            userInput = Console.ReadLine();
            int userInput1 = int.Parse(userInput);  

            numbers.Add(userInput1);

        }

        int sum = 0;
        
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
        }   

        double average = (double)sum / numbers.Count;
        int largestNumber = numbers.Max();

        Console.Write("The sum is:"+ sum);
        Console.Write("The average is:"+ average);
        Console.Write("The largest number is:"+ largestNumber);
    }
}