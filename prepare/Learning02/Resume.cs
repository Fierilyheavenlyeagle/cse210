using System.Data;

public class Resume
{

public string _name = "";
public List<Job> _jobs = new List<Job>();

public Resume()
{
}

public void DisplayDetails()

{
  Console.WriteLine($"Name: {_name}");

  foreach (Job j in _jobs)
  {
    string jobTitle = j._jobTitle;
    string jobCompany = j._company;
    string jobStartYear = j._startYear;
    string jobEndYear = j._endYear;

    Console.WriteLine($"{jobTitle} {jobCompany} {jobStartYear}-{jobEndYear}");
  }
  
}
}






