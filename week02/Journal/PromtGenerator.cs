using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>();

        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What did you learn today?");
        _prompts.Add("Who did you help today?");
        _prompts.Add("What made you smile today?");
        _prompts.Add("What was difficult for you today?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}