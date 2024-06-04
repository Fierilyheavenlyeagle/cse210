using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>();

        Console.WriteLine("Hello Foundation4 World!");

        Running running1 = new Running
        {
            time = 30,
            date = "14/05/24",
            type = "Running",
            distance = 3
        };

        activities.Add(running1);

        Cycling cycling1 = new Cycling
        {
            time = 30,
            date = "14/05/24",
            type = "Cycling",
            speed = 9.7
        };

        activities.Add(cycling1);

        Swimming swimming1 = new Swimming
        {
            time = 30,
            date = "13/05/24",
            type = "swimming",
            numberOfLaps = 4
        };

        activities.Add(swimming1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary()); 
        }


    }
}
