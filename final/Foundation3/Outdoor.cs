public class Outdoor : Event
{
  public string statement;
  public string type = "Outdoor";

  public void FullDetails()
{
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Description: {description}");
  Console.WriteLine($"Date: {date}");
  Console.WriteLine($"Time: {time}");
  Console.WriteLine($"Address: {address}");
  Console.WriteLine($"Weather: {statement}");
}

  public void ShortDescription()
{
  Console.WriteLine($"Kind of Event: {type}");
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Date: {date}");
}

}