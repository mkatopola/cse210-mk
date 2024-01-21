using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}

