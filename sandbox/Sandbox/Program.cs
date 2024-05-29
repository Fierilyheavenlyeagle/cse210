using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> Videos = new List<Video>();

        Video video1 = new Video
        {
            title = "Unboxing and Review: The Latest Smartphone",
            author = "Robert",
            length = 41,
            Comments = new List<Comment>
            {
                new Comment { Name = "Harold" , Text = "Great review! I found the information about the battery life particularly helpful."},

                new Comment { Name = "TechEnthusiast99", Text= "Awesome unboxing video! The attention to detail and thorough overview of each item was top-notch. Can't wait to get my hands on these products!"},

                new Comment { Name = "GadgetFanatic23", Text = "Great unboxing experience! Your excitement and genuine reactions made the video enjoyable to watch. Looking forward to seeing more content from you!"},

                new Comment { Name = "UnboxMaster", Text="Thanks for sharing this unboxing video! Your insights into the packaging, build quality, and included accessories were really helpful. Keep up the great work!"},
            }    
        };
        Videos.Add(video1);

        Video video2 = new Video
        {
            title = "Top 5 Kitchen Gadgets You Need in 2024",
            author = "Sarah",
            length = 75,
            Comments = new List<Comment>
            {
                new Comment { Name = "Paul" , Text= "This was an excellent unboxing and review! The camera quality and performance breakdown were particularly insightful. Keep up the great work!"},

                new Comment { Name = "GadgetGuru23" , Text ="Impressive review! The detailed breakdown of each gadget's features and performance was incredibly informative. Can't wait to upgrade my kitchen with these innovations!"},

                new Comment { Name = "KitchenExplorer", Text="Thanks for showcasing these amazing kitchen gadgets! I've been looking for ways to streamline my cooking process, and your review helped me narrow down my options. Excited to try them out!"},

                new Comment { Name = "CulinaryConnoisseur", Text="Great job on the review! The practical demonstrations of each gadget in action really helped me visualize how they would fit into my kitchen routine. Looking forward to experimenting with these tools!"}
            }
        };

        Videos.Add(video2);

        Video video3 = new Video
        {
            title = "The Ultimate Fitness Tracker",
            author = "Denise",
            length = 84,
            Comments= new List<Comment>
            {
                new Comment{ Name= "Josseline" , Text ="I love how detailed this review is! The comparison with other fitness trackers really helped me make an informed decision. The heart rate monitoring feature looks amazing!"},

                new Comment{ Name ="RunWithMe", Text="Awesome review! The detailed breakdown of the fitness tracker's GPS accuracy was exactly what I was looking for. Can't wait to try it on my next run!"},

                new Comment{ Name ="HealthNut101", Text = "Great insights on the sleep tracking feature. I've been looking for a fitness tracker that accurately monitors sleep patterns, and this one seems perfect!"},

                new Comment{ Name ="GymRatPro", Text = "Thanks for the thorough review! The comparison of different fitness modes and heart rate monitoring capabilities was super helpful. Definitely considering buying this now."},
            }
        };

        Videos.Add(video3);

        Video video4 = new Video
        {
            title =  "Exploring the Best Smart Home Devices of the Year!",
            author = "Thomas",
            length = 71,
            Comments = new List<Comment>
            {
                new Comment{ Name = "EcoFriendlyTech", Text="Thanks for highlighting the energy-efficient smart thermostats. Reducing my carbon footprint while saving on energy bills is a big win for me."},

                new Comment{ Name = "HomeAutomationGeek", Text ="Fantastic review! The smart lighting systems you showcased are impressive. I’m excited to try the one that syncs with music!"},

                new Comment{ Name = "TechSavvyMom", Text= "I loved the segment on smart security cameras. It’s reassuring to know which models offer the best motion detection and night vision."},

                new Comment{ Name = "SmartHomeEnthusiast", Text= "Great video! The comparison of different smart home hubs was really helpful. I’m leaning towards the one with the best voice assistant integration."},

            }
        };

        Videos.Add(video4);

        Console.Clear();

        foreach ( Video Video in Videos)
        {
         Console.WriteLine("Author: "+Video.author);
         Console.WriteLine(Video.title);
         Console.WriteLine(Video.length+" seconds");
         Console.WriteLine("The comments:");
         Console.WriteLine(Video.Comments.Count+" comments");
         foreach ( var comment in Video.Comments)
         {
            Console.WriteLine("()"+comment.Name);
            Console.WriteLine(comment.Text);
            Console.WriteLine("");
         }
         Console.WriteLine("------------------------------------------------------------------");
        }
        
    }
}