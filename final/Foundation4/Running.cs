public class Running : Activity
{
  public double distance;
  private double speed;
  private double pace;


    public override double Distance()
    {
      return distance;
    }
    public override double Speed()
    {
      speed= distance / time * 60;
      return speed;
    }
    public override double Pace()
    {
      pace= time / distance;
      return pace;
    }
}
