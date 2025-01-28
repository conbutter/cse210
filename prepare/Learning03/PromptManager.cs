public class PromptManager
{
    // ATTRIBUTE DECLARATION
    public static List<string> _prompts = new List<string>() {"Prompt 1 Here", "Prompt 2 Here", "Prompt 3 Here"};

    // MODULE DECLARATION

    public string GetRandomPrompt() {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];
        return selectedPrompt;
    }
}