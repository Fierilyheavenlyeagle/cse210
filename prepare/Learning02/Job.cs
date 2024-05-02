using System.Runtime.CompilerServices;

public class Job 
{
  public string _company = "";
  public string _jobTitle = "";
  public string _startYear = "";
  public string _endYear = "";

  public Job()
  { 
  }

  public void Display()
  {
    Console.WriteLine($"{_company}");
  }
  public void DisplayJobDetails()
  {
    Console.WriteLine($"{_jobTitle} {_company} {_startYear}-{_endYear}");
  }
}
