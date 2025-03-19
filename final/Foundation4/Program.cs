using System;

class Program
{
    private static List<Activity> _activities = new List<Activity>();

    static void Main(string[] args)
    {
        // Creating activities
        RunningActivity running1 = new RunningActivity("14 Jan 2025", 45, 2.0);
        _activities.Add(running1);
        CyclingActivity cycling1 = new CyclingActivity("15 Jan 2025", 30, 13.5);
        _activities.Add(cycling1);
        SwimmingActivity swimming1 = new SwimmingActivity("17 Jan 2025", 15, 4);
        _activities.Add(swimming1);

        // Display to console
        Console.Clear();
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}