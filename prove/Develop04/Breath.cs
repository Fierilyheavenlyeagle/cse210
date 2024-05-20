using System.Diagnostics;

public class Breath : Activity
{
  private string _breathIn = "Breath in...";

  private string _breathOut = "Breath out...";

  private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
  

  private string _timerSentence;
  private int _sessionTime;

  public Breath(string activity, int second, int spinnerSecond, string spinnerSentence) : base(activity,second,spinnerSecond,spinnerSentence)
  {
  }

  public string Description()
{
  return $"{_description}";
}

  public string BreathIn()
  {
    return _breathIn;
  }

  public string BreathOut()
  {
    return _breathOut;
  }
  public string BreathSpinner()
  {
    List <string> animationString = new List<string> {"|","/","-","\\"};

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(4);

    int i = 0;
    string result = "";

    while (DateTime.Now < endTime)
    {
      string s = animationString[i];
      Console.Write(s);
      Thread.Sleep(400);
      Console.Write("\b \b");

      i++;

      if (i >= animationString.Count)
      {
        i=0;
      }
    }
    return result;
  }
  public string BreathTimer(string timerSentence, int sessionTime)
  {
    _sessionTime = sessionTime;
    _timerSentence = timerSentence;
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(5);

    int i = _sessionTime;
    string result = "";
    Console.Write($"{_timerSentence}");

    while (DateTime.Now < endTime)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
      

      i--;
      if ( i < 1 )
      {
      break;
      }
    }
    return result;
    
}
  
  
}