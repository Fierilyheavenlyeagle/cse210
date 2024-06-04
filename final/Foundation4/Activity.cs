public abstract class Activity
{
  public string date;
  public double time;
  
  public string type;
  public abstract double Distance();

  public abstract double Speed();
  public abstract double Pace();

  public string GetSummary()
  {
    double distance = Distance();
    double speed = Speed();
    double pace = Pace();
    return $"{date} {type} ({time})- Distance {distance} miles, Speed {speed} mph, Pace: {pace:F1} min per mile";
  }
}