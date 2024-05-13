using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Rodgrigo", "History");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment assignment1 = new MathAssignment("Diego", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetHomeworkList());
        
        WritingAssignment assignment2 = new WritingAssignment("Carla Moscozo","Biology","The hybridization of Robots with Biology");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetWritingInformation());

    }
}