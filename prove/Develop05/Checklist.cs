public class Checklist : GoalSet
{

  public Checklist(string name, string description, int points, int timesToWin , int bonusPoints,string type, int completed): base(name, description, points, "Checklist")
  {
      Name = name;
      Description = description;
      Points = points;
      TimesToWin=timesToWin;
      BonusPoints=bonusPoints;
      Type = type;
      Completed = completed;
  }

  public override void DisplayQuestions()
  {
    Console.WriteLine("What is the name of your goal?");
    userInputName = Console.ReadLine();
    Console.WriteLine("What is a short description of it:");
    userInputDescription = Console.ReadLine();
    Console.WriteLine("How many points associated with this goal?");
    userInputPoints = int.Parse(Console.ReadLine());
    Console.WriteLine("How many times does this goal need to be accomplished to get a bonus?");
    timesToWin = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the bonus for accomplishing it that many times?");
    bonus = int.Parse(Console.ReadLine());
  }

}