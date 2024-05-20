using System;

class Program
{
  static void Main(string[] args)
  {
  while (true)
  {
    Console.Clear();
    Console.WriteLine("Menu Options:");
    Console.WriteLine("1.Start breathing activity");
    Console.WriteLine("2.Start reflecting activity");
    Console.WriteLine("3.Start listing activity");
    Console.WriteLine("4.Quit");
    Console.WriteLine("Select a choice from the menu:");
    string userinput;
    userinput = Console.ReadLine();
    Console.Clear();
    int second = 1;
    if (userinput == "1")
    {
    Breath breathActivity = new Breath("Breath",second,1,"");
    Console.WriteLine(breathActivity.GetWelcome());
    Console.WriteLine("");
    Console.WriteLine(breathActivity.Description());
    Console.WriteLine("");
    Console.WriteLine(breathActivity.Prompter());
    second = int.Parse(Console.ReadLine());
    string breathIn = breathActivity.BreathIn();
    string breathOut = breathActivity.BreathOut();
    Console.Clear();
    Breath breathActivity1 = new Breath("Breathing",second,4,breathIn);
    Console.WriteLine(breathActivity1.GetReady());
    Console.WriteLine(breathActivity1.Spinner());

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(second);
    while (DateTime.Now < endTime)
    {
    Console.WriteLine(breathActivity1.BreathTimer(breathIn,4));
    Console.WriteLine(breathActivity1.BreathTimer(breathOut,6));
    Console.WriteLine("");
    }
    Console.WriteLine(breathActivity1.WellDone());
    Console.WriteLine("");
    Console.WriteLine(breathActivity1.Completed());
    Console.WriteLine("");
    Console.WriteLine(breathActivity1.Spinner());
    }
    else if ( userinput == "4")
    {
      break;
    }
    if (userinput == "2")
    {
    Reflection reflectionActivity = new Reflection("Reflection",second,1,"");
    Console.WriteLine(reflectionActivity.GetWelcome());
    Console.WriteLine("");
    Console.WriteLine(reflectionActivity.Description());
    Console.WriteLine("");
    Console.WriteLine(reflectionActivity.Prompter());
    second = int.Parse(Console.ReadLine());
    Console.Clear();
    Reflection reflectionActivity1 = new Reflection("Reflection",second,4,"");
    Console.WriteLine(reflectionActivity1.GetReady());
    Console.WriteLine(reflectionActivity1.Spinner());
    reflectionActivity1.Run();
  }
  else if ( userinput == "4")
    {
      break;
    }

  if (userinput == "3")
  {
    Listing listingActivity = new Listing("Listing",second,1,"");
    Console.WriteLine(listingActivity.GetWelcome());
    Console.WriteLine("");
    Console.WriteLine(listingActivity.Description());
    Console.WriteLine("");
    Console.WriteLine(listingActivity.Prompter());
    second = int.Parse(Console.ReadLine());
    Console.Clear();
    Listing listingActivity1 = new Listing("Listing",second,4,"");
    Console.WriteLine(listingActivity1.GetReady());
    Console.WriteLine(listingActivity1.Spinner());
    listingActivity1.run();
    Console.WriteLine("");
    int count = (listingActivity1.GetListFromUser(second)).Count;
    Console.WriteLine($"You have listed {count} items!");
    Console.WriteLine("");
    Console.WriteLine(listingActivity1.WellDone());
    Console.WriteLine(listingActivity1.Spinner());
    Console.WriteLine(listingActivity1.Completed());
    Console.WriteLine(listingActivity1.Spinner());

  }
  else if ( userinput == "4")
    {
      break;
    }
  }

}
}