using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection.Metadata;

public class Goal
{
  public string goal="hola";
  public int userInput;

  public int choice = 1;

  public string fileName = "memory.txt";

  public double _totalPoints;

  public int recordEvent;

  public double eternalPoints; 

  public double checkPoints;

  public double simplePoints;
  public List<GoalSet> GoalsNames = new List<GoalSet>();

  public int timesToWin;
  public int bonus;

  public int totalPoints;
  public void ChooseGoal()
  {
    Console.WriteLine("The types of goals are:");
    Console.WriteLine("1.Simple Goal");
    Console.WriteLine("2.Eternal Goal");
    Console.WriteLine("3.Checklist Goal");
    Console.WriteLine("Which type of goal would you like to create?");
    userInput = int.Parse(Console.ReadLine());
  }
  public void menu()
  { 
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1.Create New Goal");
        Console.WriteLine("2.List Goals");
        Console.WriteLine("3.Save Goals");
        Console.WriteLine("4.Load Goals");
        Console.WriteLine("5.Record Event");
        Console.WriteLine("6.Quit");
        Console.WriteLine("Select a choice from the menu:");
        choice = int.Parse(Console.ReadLine());
  }



  public void ListGoals()
  {
    string [] lines = System.IO.File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
      string[] parts = line.Split(";");

      if (parts.Length <=1)
      {
      string points = parts[0];

      Console.WriteLine($"{points}");
      }
      else if (parts.Length <=3)
      {
      string name = parts[0];
      string description = parts[1];

      Console.WriteLine($"[ ] {name} ({description})");
      }
      else if (parts.Length <=4)
      {
      string name = parts[0];
      string description = parts[1];
      string boolean = parts[3];

      if (boolean == "True") 
      {
      Console.WriteLine($"[ ] {name} ({description})");
      }
      else if (boolean == "False")
      {
        Console.WriteLine($"[x] {name} ({description})");
      }

      }

      else if (line.Length >4)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];
      string times = parts[3];
      string bonusPoints = parts[4];
      string completed = parts[5];

          
      if (times != completed) 
      {
      Console.WriteLine($"[ ] {name} ({description}) - Currently completed: {completed}/{times}");
      }
      else if (times == completed)
      {
      Console.WriteLine($"[x] {name} ({description}) - Currently completed: {times}/{times}");
      }
      

      }
      
    }
  }
  public void saveListGoals()
  {
    Console.WriteLine("what is the filename?");
    string fileSaveName = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileName);

    foreach(string line in lines)
    {
      string[] parts = line.Split(";");
      if (parts.Length <=1)
      {
      _totalPoints = int.Parse(parts[0]);

      using (StreamWriter outputFile = new StreamWriter(fileSaveName,true))
      {
        outputFile.WriteLine($"{_totalPoints}");
      }
      }

      else if (parts.Length <= 3)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];

      using (StreamWriter outputFile = new StreamWriter(fileSaveName, true))
          {
            outputFile.WriteLine($"{name};{description};{points}");
      }
      }
      else if (parts.Length <=4)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];
      string boolean = parts[3];

      using (StreamWriter outputFile = new StreamWriter(fileSaveName, true))
          {
            outputFile.WriteLine($"{name};{description};{points};{boolean}");
      }

      }
      else if (line.Length >4)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];
      string times = parts[3];
      string bonusPoints = parts[4];

      using (StreamWriter outputFile = new StreamWriter(fileSaveName, true))
          {
            outputFile.WriteLine($"{name};{description};{points};{times};{bonusPoints}");
      }
      }
    }
   System.IO.File.WriteAllText(fileName,string.Empty);
   SetPoints();

  }
  public void SetPoints()
  {
  totalPoints = 0;

  using (StreamWriter outputFile = new StreamWriter(fileName,true))
  {
    outputFile.WriteLine($"{totalPoints}");
  }
  }
  public void DisplayPoints()
  {
  string[] lines = System.IO.File.ReadAllLines(fileName);

  totalPoints = int.Parse(lines[0]);

  Console.WriteLine($"You have {totalPoints} points");
  }

  public void showGoals()
  {
    Console.WriteLine("The Goals are:");

    string[] lines = System.IO.File.ReadAllLines(fileName);

     foreach (string line in lines)
    {
      string[] parts = line.Split(";");

      if (parts.Length <=1)
      {
      string points = parts[0];
      Console.WriteLine($"");
      }
      else if (parts.Length <=3)
      {
      string name = parts[0];
      string description = parts[1];
      int points = int.Parse(parts[2]);
      eternalPoints = int.Parse(parts[2]);

      GoalsNames.Add(new Eternal(name, description, points, "Eternal"));
      }
      else if (parts.Length <=4)
      {
      string name = parts[0];
      string description = parts[1];
      int points = int.Parse(parts[2]);
      simplePoints = int.Parse(parts[2]);
      string boolean = parts[3];


      GoalsNames.Add(new Simple(name, description, points, "true","Simple"));
      
      }
      else if (line.Length >4)
      {
      string name = parts[0];
      string description = parts[1];
      int points = int.Parse(parts[2]);
      checkPoints = int.Parse(parts[2]);
      int times = int.Parse(parts[3]);
      int bonusPoints = int.Parse(parts[4]);
      bonus = int.Parse(parts[4]);
      int completed = int.Parse(parts[5]);

      GoalsNames.Add(new Checklist(name, description, points,times, bonusPoints, "Checklist", completed));
      
      }
   }

       for (int i = 0; i<GoalsNames.Count; i++)
    {
      Console.WriteLine($"{i+1}.{GoalsNames[i].Name}");
    }
    {
      recordEvent = int.Parse(Console.ReadLine());

      var selectedGoal = GoalsNames[recordEvent - 1];

      if (selectedGoal.Type == "Simple")
      {
        totalPoints = int.Parse(lines[0]);
        _totalPoints = totalPoints + simplePoints;
        lines[0] = $"{_totalPoints}";
        selectedGoal.Boolean = "False";
        lines[recordEvent] = $"{selectedGoal.Name};{selectedGoal.Description};{selectedGoal.Points};{selectedGoal.Boolean}";
        File.WriteAllLines(fileName, lines);
      }

      else if (selectedGoal.Type == "Eternal")
        {
          totalPoints = int.Parse(lines[0]);
          _totalPoints = totalPoints + eternalPoints;
          lines[0] = $"{_totalPoints}";
          File.WriteAllLines(fileName, lines);
        }
      else if (selectedGoal.Type == "Checklist")
        {
          totalPoints = int.Parse(lines[0]);
          _totalPoints = totalPoints + checkPoints;
          lines[0] = $"{_totalPoints}";
          selectedGoal.Completed = selectedGoal.Completed +1;
          lines[recordEvent] = $"{selectedGoal.Name};{selectedGoal.Description};{selectedGoal.Points};{selectedGoal.TimesToWin};{selectedGoal.BonusPoints};{selectedGoal.Completed}";
          File.WriteAllLines(fileName, lines);

          if (selectedGoal.Completed == selectedGoal.TimesToWin)
          {
            totalPoints = int.Parse(lines[0]);
            _totalPoints = totalPoints + bonus;
            lines[0] = $"{_totalPoints}";
            File.WriteAllLines(fileName, lines);

            Console.WriteLine($"Congratulations!, You have earned {bonus} bonus points! :D ");
          }
        }
    }

    GoalsNames.Clear();
    }


  public void LoadToMemory()
  {
    System.IO.File.WriteAllText(fileName,string.Empty);
    Console.WriteLine("What is the filename fot the goal file?");
    string fileSaveName1 = Console.ReadLine();

    string[] lines = System.IO.File.ReadAllLines(fileSaveName1);

    foreach(string line in lines)
    {
      string[] parts = line.Split(";");
      if (parts.Length <=1)
      {
      string points = parts[0];

      using (StreamWriter outputFile = new StreamWriter(fileName,true))
      {
        outputFile.WriteLine($"{points}");
      }
      }

      else if (parts.Length <= 3)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];

      using (StreamWriter outputFile = new StreamWriter(fileName, true))
          {
            outputFile.WriteLine($"{name};{description};{points}");
      }
      }
      else if (parts.Length <= 4)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];
      string boolean = parts[3];

      using (StreamWriter outputFile = new StreamWriter(fileName, true))
          {
            outputFile.WriteLine($"{name};{description};{points};{boolean}");
      }
      }

      else if (line.Length >3)
      {
      string name = parts[0];
      string description = parts[1];
      string points = parts[2];
      string times = parts[3];
      string bonusPoints = parts[4];

      using (StreamWriter outputFile = new StreamWriter(fileName, true))
          {
            outputFile.WriteLine($"{name};{description};{points};{times};{bonusPoints}");
      }
      }
      System.IO.File.WriteAllText(fileSaveName1,string.Empty);
      
    }
  }
}
