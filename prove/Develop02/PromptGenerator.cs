


public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        string prompt = _prompts[randomGenerator.Next(0, _prompts.Count)];
        return prompt;
    }


}

