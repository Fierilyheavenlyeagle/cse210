using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;

public class Activity
{
  public string _activity;
  protected string _prompter = "How long in seconds, would you like for your session?";

  protected string _wellDone= "Well Done!";

  public int _second;
  public int _spinnerSecond;

  public string _spinnerSentence;

  protected string _completed;

  private string _getReady = "Get ready ....";

public Activity(string activity, int second, int spinnerSecond, string spinnerSentence)
{
  _activity = activity;
  _second = second;
  _spinnerSecond = spinnerSecond;
  _spinnerSentence = spinnerSentence;
  
}


public string GetWelcome()
{
  return $"Welcome to the {_activity} Activity";
  
}
public string Prompter()
{
  return $"{_prompter}";
}
public string WellDone()
{
  return $"{_wellDone}";
}
public string Completed()
{
  return $"You have completed another {_second} seconds of the {_activity} Activity";
}

public string Timer(int spinnerSeconds, string spinnerSentence)
  {
    _spinnerSentence = spinnerSentence;
    _spinnerSecond = spinnerSeconds;

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_second);

    int i = _spinnerSecond;
    string result = "";
    
    Console.Write($"{_spinnerSentence}");
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

  public string Spinner()
  {
    List <string> animationString = new List<string> {"|","/","-","\\"};

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(_spinnerSecond);

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

 public string GetReady ()
  {
    return $"{_getReady}";
  }

}

