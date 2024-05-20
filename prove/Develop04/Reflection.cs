using System.Diagnostics;

public class Reflection : Activity
{
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    private List<String> _prompts = new List<string>
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless.",
    };

    private List<String> _questions = new List<string>
    {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?",
    };

    public Reflection(string activity, int second, int spinnerSecond, string spinnerSentence) : base(activity,second,spinnerSecond,spinnerSentence)
    {

    }

    public string Description()
    {
        return $"{_description}";
    }

    public string GetRandomPrompt()
    {
      Random random = new Random();
      int randomindexNum = random.Next(_prompts.Count);
      string randomPrompt =_prompts[randomindexNum];
      return randomPrompt;
    }
    public void DisplayPrompt()
    {
      string randomPrompt1 = GetRandomPrompt();
      Console.WriteLine(randomPrompt1);
    }
    public string GetRandomQuestion()
    {
      Random random= new Random();
      int randomIndexNum = random.Next(_questions.Count);
      string randomQuestion = _questions[randomIndexNum];
      return randomQuestion;
    }
    public void DisplayQuestion()
    {
      string randomQuestion1= GetRandomQuestion();
      _spinnerSecond = 15;
      Console.Write(randomQuestion1);
      Console.Write(Spinner());
    }

    public void Run()
    {
      Console.WriteLine("Consider the following prompt:");
      DisplayPrompt();
      Console.WriteLine("When you have something in mind, press enter to continue.");
      Console.ReadLine();
      Console.Clear();
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(_second);
      while (DateTime.Now < endTime)
      {
        DisplayQuestion();
        Console.WriteLine("");
      }
      _spinnerSecond = 4;
      Console.WriteLine("");
      Console.WriteLine(_wellDone);
      Console.WriteLine(Spinner());
      Console.WriteLine(Completed());
      Console.WriteLine(Spinner());
    }



}
