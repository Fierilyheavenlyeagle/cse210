public class Cycling:Activity
{
  public double speed;
  private double distance;
  private double pace;

  public override double Distance()
  {
      distance = time * speed;
      return distance;
  }
    public override double Speed()
    {
     return speed;
    }
    public override double Pace()
  {
      pace = 60 / speed;
      return pace;
  }

}