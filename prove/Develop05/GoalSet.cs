public class GoalSet
{
    public string Name;
    public string Description;
    public int Points;
    public string Boolean;
    public int TimesToWin;
    public int BonusPoints;
    public string Type;
    public string userInputDescription;

    public string userInputName;

    public int userInputPoints;

    public int timesToWin;
    public int bonus;

    public int Completed;

    public string fileName = "memory.txt";
    

    public GoalSet(string name, string description, int points, string type) 
    {
        Name = name;
        Description = description;
        Points = points;
        Type = type;
    }

    public virtual void DisplayQuestions()
  {
    Console.WriteLine("What is the name of your goal?");
    userInputName = Console.ReadLine();
    Console.WriteLine("What is a short description of it:");
    userInputDescription = Console.ReadLine();
    Console.WriteLine("How many points associated with this goal?");
    userInputPoints = int.Parse(Console.ReadLine());
  }

   public void RunEternal()
  {
    using (StreamWriter outputFile = new StreamWriter(fileName,true))
    {
      outputFile.WriteLine($"{userInputName};{userInputDescription};{userInputPoints}");
    }
  }

   public void RunSimple()
 {
  using (StreamWriter outputFile = new StreamWriter(fileName, true))
  {
    outputFile.WriteLine($"{userInputName};{userInputDescription};{userInputPoints};True");
  }
 }

  public void RunCheck()
  {
    using(StreamWriter outputFile = new StreamWriter(fileName,true))
    {
      outputFile.WriteLine($"{userInputName};{userInputDescription};{userInputPoints};{timesToWin};{bonus};{Completed}");
    }
  }

}
