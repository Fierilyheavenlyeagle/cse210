public class Swimming: Activity
{
public double numberOfLaps;
private double distance;

private double speed;
public override double Distance()
    {
      distance =  numberOfLaps * 50 / 1000;
      return distance;
    }
    public override double Speed()
    {
      speed = (distance / time) * 60;
      return speed;
    }
    public override double Pace()
    {
      double pace = 60 / speed;
      return pace;
    }
}