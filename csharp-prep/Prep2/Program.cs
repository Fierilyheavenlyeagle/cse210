using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput= Console.ReadLine();
        int userGrade = int.Parse(userInput);
        string letterGrade;

        if  (userGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (userGrade >= 80 )
        {
            letterGrade = "B";
        }
        else if (userGrade >= 70)
        {
           letterGrade = "C";
        }
        else if (userGrade >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }

        Console.WriteLine($"You got this semester an {letterGrade}");

        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congratulations! You passed the semester");
        }
        else if (letterGrade == "D" || letterGrade == "F")
        {
            Console.WriteLine("Unfortunately my fellow friend, but next time will be better!");
        }


    }
}