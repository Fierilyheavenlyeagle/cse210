using System;

class Program
{
    static void Main()
    {
        Goal choose = new Goal();
        choose.SetPoints();
        while(choose.choice != 6)
        {
        choose.DisplayPoints();
        choose.menu(); 
        if (choose.choice == 1)
        {
            choose.ChooseGoal();
            if (choose.userInput == 1)
            {
            Simple goal1 = new Simple("a","a",1,"a","a");
                goal1.DisplayQuestions();
                goal1.RunSimple();
            }
            else if (choose.userInput == 2)
            {
            Eternal goal2 = new Eternal("a","a",1,"a");
                goal2.DisplayQuestions();
                goal2.RunEternal();
            }
            else if (choose.userInput == 3)
            {
            Checklist goal3 = new Checklist("a","a",1,2,3,"a",0);
                goal3.DisplayQuestions();
                goal3.RunCheck();

            }
        }
        else if (choose.choice == 2)
        {
            choose.ListGoals();
        }
        else if (choose.choice == 3)
        {
            choose.saveListGoals();
        }
        else if (choose.choice == 4)
        {
            choose.LoadToMemory();
        }
        else if (choose.choice == 5)
        {
            choose.showGoals();
        }
        
        }
        System.IO.File.WriteAllText(choose.fileName,string.Empty);
        
    }
}