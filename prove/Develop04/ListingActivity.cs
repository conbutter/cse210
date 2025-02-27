using System;
using System.ComponentModel;

class ListingActivity : Activity
{
    // Attribute declaration

    private List<string> _prompts = new List<string>{
        "What are personal strengths of yours?",
        "Who are people that you appreciate?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _responses = new List<string>();

    // Constructor declaration

    public ListingActivity(string name, string desc) : base(name, desc)
    {
        // No additional elements for constructor
    }

    // Module declaration

    public void DoActivity()
    {
        // Prompt display and wait
        Random random = new Random();
        string chosenPrompt = _prompts[random.Next(0, _prompts.Count)];
        Console.WriteLine($"List as many responses that you can to the following prompt:\n\n[ {chosenPrompt} ]\n");
        ShowCountDown("Your time starts in: ", 5);

        // Style writing screen
        Console.Clear();
        Console.WriteLine($"[ {chosenPrompt} ]");

        // Finish time definer
        DateTime startTime = DateTime.Now;
        DateTime finishTime = startTime.AddSeconds(GetDuration());

        // Main activity loop
        while (DateTime.Now < finishTime)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            _responses.Add(userInput);
        }
        Console.WriteLine($"You wrote {_responses.Count()} responses! Great job!");
    }
}