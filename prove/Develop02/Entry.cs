using System;
using System.Collections.Generic;

public class Entry
{
    public void PrintEntries()
    {
        List<string> entries = new List<string>()
        {
        "Welcome to the Journal Program!",
        "Please select one of the following choices:",
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit",
        "What would you like to do?",
        };

        foreach (string Entry in entries)
        {
        Console.WriteLine(Entry);
        }
    }
 

}