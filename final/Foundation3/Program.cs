using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture1 = new Lectures
        {
            eventTitle = "Annual Charity Gala",
            description= "A formal event to raise funds for local charities.",
            date = "June 15, 2024",
            time = "7:00 PM - 10:00 PM",
            address = "Grand Ballroom, Hotel Luxe, 123 Main Street, Cityville",
            speakerName = "Julio Cortázar",
            capacity = 500,
        };

        Receptions reception1 = new Receptions
        {
            eventTitle = "Networking Reception for Entrepreneurs",
            description = "An opportunity for local entrepreneurs to network and share ideas.",
            date = "August 5, 2024",
            time = "6:00 PM - 8:00 PM",
            address = "Riverside Lounge, 202 Commerce Street, BizCity",
            email = "rsvp@entrepreneurevent.com"
            
        };

        Outdoor outdoor1 = new Outdoor
        {
            eventTitle= "Summer Picnic in the Park",
            description= "A family-friendly picnic with games and activities.",
            date= "June 20, 2024",
            time= "11:00 AM - 3:00 PM",
            address= "Central Park, 303 Park Road, Greentown",
            statement = "Event will proceed rain or shine; bring appropriate fit.",
        };

        lecture1.StandardDetails();
        Console.WriteLine("");
        lecture1.FullDetails();
        Console.WriteLine("");
        lecture1.ShortDescription();
Console.WriteLine("////////////////////////////////////////////////////");
        reception1.StandardDetails();
        Console.WriteLine("");
        reception1.FullDetails();
        Console.WriteLine("");
        reception1.ShortDescription();
Console.WriteLine("////////////////////////////////////////////////////");
        outdoor1.StandardDetails();
        Console.WriteLine("");
        outdoor1.FullDetails();
        Console.WriteLine("");
        outdoor1.ShortDescription();
    }
}