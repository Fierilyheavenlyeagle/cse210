using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.IO;
using System.Dynamic;

class Program
{ 
    static void Main(string[] args)
    {   
        
            string toDo = "";
            while ( toDo != "5"){
            
            Entry entry = new Entry();
            entry.PrintEntries();
            toDo = Console.ReadLine();

             if (toDo == "1")
            {   
                    string userWrite;
                    PromptGenerator prompt = new PromptGenerator();
                    string question = prompt.GetRandomPrompt();
                    Console.WriteLine(question);
                    userWrite = Console.ReadLine();

                    string fileName = "common.txt";

                    using (StreamWriter outputFile = new StreamWriter(fileName, true))
                    {
                       DateTime theCurrentTime = DateTime.Now;
                       string dateText = theCurrentTime.ToShortDateString(); 
                       string dateText1 = $"Date: {dateText}";
                       string write =$"- Prompt: {question} {userWrite}";
                       outputFile.WriteLine($"{dateText1}, {write}");
                    }
                }
               
                
                else if (toDo == "2")
                {
                    string filename = "common.txt";
                    string[] lines = System.IO.File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(",");
                        string date = parts[0];
                        string writting= parts[1];

                       Console.WriteLine($"{date}, {writting}");
                    }
                            
                }

                else if (toDo == "3")
                {
                    Console.WriteLine("What is the filename?");

                    string fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    foreach ( string line in lines)
                    {
                        string[] parts = line.Split(",");
                        string date = parts[0];
                        string writting = parts[1];
                        Console.WriteLine($"{date}, {writting}");
                    }
                    
                }
                

                else if (toDo == "4")
                {
                    Console.WriteLine("What is the filename?");
                    string fileName = Console.ReadLine();

                    string[] lines = System.IO.File.ReadAllLines("common.txt");

                    System.IO.File.WriteAllText("common.txt", string.Empty);
                    
                    foreach(string line in lines)
                    {
                        string[] parts = line.Split(",");
                        string date = parts[0];                                                                         
                        string writting = parts[1];     

                        using (StreamWriter outputFile = new StreamWriter(fileName, true))
                        {
                            outputFile.WriteLine($"{date},{writting}");
                        }       
                    }

                    

                }  
            }
            
              
    }

}