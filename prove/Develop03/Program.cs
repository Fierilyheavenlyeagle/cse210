using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
      
      Console.Clear();
      string scripture = " Porque el Espíritu mismo da testimonio a nuestro espíritu de que somos hijos de Dios.";
      Reference reference = new Reference("Romanos", 8, 16);
      string userinput = "";
      string displayText = " ";
      int numberToHide = 2;
      bool boolean = false;   
      string reference1 = "Romanos 8 : 16";
      Console.WriteLine($"{reference1}");
      Console.WriteLine($"{scripture}");
      Console.WriteLine("Press enter to continue or type 'quit' to finish");
      userinput = Console.ReadLine();
      if (userinput != "quit")
      {
        reference = new Reference("Romanos", 8, 16);
        Scripture instance = new Scripture(scripture, reference);
        instance.HideRandomWord(numberToHide);
        reference1 = instance.GetDisplayReference();
        displayText= instance.GetDisplayText();
        Console.Clear();    
        Console.WriteLine(reference1);
        Console.WriteLine(displayText);
        Console.WriteLine("Press enter to continue or type 'quit' to finish"); 
        userinput = Console.ReadLine();
      }
      while (userinput != "quit" && boolean != true)
       if (userinput != "quit")
         {
            userinput = "";
            scripture = displayText;     
            Scripture instance = new Scripture(scripture, reference);
            instance.HideRandomWord(numberToHide);
            reference1 = instance.GetDisplayReference();
            displayText= instance.GetDisplayText();
            boolean = instance.IsCompletelyHidden();
           Console.Clear();    
            Console.WriteLine(reference1);
            Console.WriteLine(displayText);
            Console.WriteLine("Press enter to continue or type 'quit' to finish"); 
            userinput = Console.ReadLine();
          }
        else if (userinput == "quit")
        {
        Console.WriteLine("Program Finished");
        break;
        }
       Console.WriteLine("Program Finished");
    }
   
    public static string HideAndDisplay(string scripture, Reference reference, int numberToHide=1)
    {
        string modifiedScripture = scripture;
        Scripture instance = new Scripture(modifiedScripture, reference);
        instance.HideRandomWord(numberToHide);
        return instance.GetDisplayReference();
           
    }
}