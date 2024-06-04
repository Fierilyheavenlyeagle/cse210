public class Receptions : Event
{
  public string  email;
  public string type = "Reception";

  public void FullDetails()
{
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Description: {description}");
  Console.WriteLine($"Date: {date}");
  Console.WriteLine($"Time: {time}");
  Console.WriteLine($"Address: {address}");
  Console.WriteLine($"Email: {email}");
}

  public void ShortDescription()
{
  Console.WriteLine($"Kind of Event: {type}");
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Date: {date}");
}
}