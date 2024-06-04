public class Lectures : Event
{
public string speakerName;
public int capacity;
public string type = "Lecture";

public void FullDetails()
{
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Description: {description}");
  Console.WriteLine($"Date: {date}");
  Console.WriteLine($"Time: {time}");
  Console.WriteLine($"Address: {address}");
  Console.WriteLine($"Speaker: {speakerName}");
  Console.WriteLine($"Capacity: {capacity}");
}

public void ShortDescription()
{
  Console.WriteLine($"Kind of Event: {type}");
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Date: {date}");
}
}