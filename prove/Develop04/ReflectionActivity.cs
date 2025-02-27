using System;
using System.ComponentModel;

class ReflectionActivity : Activity
{
    // Attribute declaration

    private List<string> _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Recall a moment where you helped someone in need.",
            "Remember an achievement that made you feel proud."
        };
    private List<string> _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn from this experience?",
            "How did you show resilience in this situation?",
            "What would you do differently if faced with a similar challenge?",
            "What action are you most proud of?",
            "How did you feel immediately after the experience?",
            "How often do you remember this instance?",
            "Do you remember this experience in times of stress? If not, what can you do to remember it going forward?",
            "What was your favorite part about the experience?"
        };

    // Constructor declaration

    public ReflectionActivity(string name, string desc) : base(name, desc)
    {
        // No additional elements
    }

    // Module declaration

    public void DoActivity()
    {
        Random random = new Random();
        string chosenPrompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"Consider the following prompt:\n\n[ {chosenPrompt} ]\n\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now, ponder on each of the following questions in the way that they relate to your experience.");
        ShowCountDown("Questions start in...", 5);

        Console.Clear();
        Console.WriteLine($"[ {chosenPrompt} ]");

        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < finishTime) // Show questions loop
        {
            Console.WriteLine($"> {_questions[random.Next(_questions.Count)]}");
            ShowAnimation(10);
        }
    }
}