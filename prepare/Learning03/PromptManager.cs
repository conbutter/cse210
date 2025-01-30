public class PromptManager
{
    // ATTRIBUTE DECLARATION
    public List<string> _prompts = new List<string>() {"What was the best part of your day?", 
    "How are you feeling right now?", "What are you looking forward to?", "If I could do one thing differently today, it would be:",
    "What was the most exciting part of your day?", "Is there anything that surprised you today?"};

    // MODULE DECLARATION

    public string GetRandomPrompt() {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];
        return selectedPrompt;
    }
}