using System;
public class PromptGenerator
{
    // The purpose of this is to generate prompts 
    //We have created a list to get all the prompts for the user...

    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who was the most interesting person you met today?",
        "What are your goals for next week?",
        "Describe something that made you smile today.",
        "What are you most proud about yourself today?",
        "What was the first thing you thought of when you woke up?",
        "What is one thing you want to improve on today?",
        "What skill did you learn today or improve on?"
    };

    
    // Method to get a random prompt
    public string GetRandomPrompt()
    {
        Random rand = new Random();

        // the variable index will get the random prompt from the computer
        int index = rand.Next(_prompts.Count);

        //We want to return the indexed item from the random generator
        return _prompts[index];
    }
}