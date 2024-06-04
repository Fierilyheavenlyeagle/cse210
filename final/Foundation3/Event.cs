public class Event
{
  public string eventTitle;
  public string  description;
  public string  date;
  public string  time;
  public string  address;


 public void StandardDetails()
{
  Console.WriteLine($"Title: {eventTitle}");
  Console.WriteLine($"Description: {description}");
  Console.WriteLine($"Date: {date}");
  Console.WriteLine($"Time: {time}");
  Console.WriteLine($"Address: {address}");
}
 

}
