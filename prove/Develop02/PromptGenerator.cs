using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> prompts;
    public PromptGenerator()
    {

    prompts = new List<string>()

            {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            };
    }
 
    public string GetRandomPrompt()
    {
        
        Random random = new Random(); //iniciate a random number generator
        int randomindexNum = random.Next(prompts.Count);//Get a random index
       
        return prompts[randomindexNum];
        
    }
}