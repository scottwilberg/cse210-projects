public class PromptGenerator
{
    public List<string> _prompts = ["If I had one thing I could do over today, what would it be?", 
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?"];

    public string GetRandomPrompt()
    {
        // to get a random question from the writeOptions list
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        // sputting the random question in a string so I can add it to the journal entry item
        string randomString = _prompts[index];
        return randomString;
    }
}