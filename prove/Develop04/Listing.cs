using System.Diagnostics;

public class Listing : Activity
{
  private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

  private List<String> _prompts = new List<string>
  {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?",
  };

  public Listing(string activity, int second, int spinnerSecond, string spinnerSentence) : base(activity,second,spinnerSecond, spinnerSentence)
  {
  }

  public string Description()
  {
    return $"{_description}";
  }

  private void GetRandomPrompt()
  {
    Random random = new Random();
    int randomIndexNum = random.Next(_prompts.Count);
    string randomPrompt = _prompts[randomIndexNum];
    Console.WriteLine($"---{randomPrompt}---");
  }

  public void run()
  {
    Console.WriteLine("List as many responses you can to the following prompt");
    Console.WriteLine("");
    GetRandomPrompt();
    Console.WriteLine("");
    Console.Write("You may begin in:");
    Console.Write(Spinner());
  }

  public List<String> GetListFromUser(int second)
  {
    List<string> sentences = new List<string>();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(second);

    while (DateTime.Now < endTime)
    {
      Console.Write(">");
      string indSentence = Console.ReadLine();
      if (true)
      sentences.Add(indSentence);
    }
    return sentences;



    

  }

  
}