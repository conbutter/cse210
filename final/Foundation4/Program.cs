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

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

// For each activity, they do not want to store this information,
// but they would like to be able to get following information
// (by calculation if it is not stored directly):
//     The distance
//     The speed (miles per hour or kilometers per hour)
//     The pace (minutes per mile or minutes per kilometer)
//     A summary in the form of:
//         03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
//         03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
// You may choose if your program uses miles or kilometers (you do not need to handle both).
// In either case the length of a lap in the lap pool is 50 meters.

// Once you have the classes in place,
// write a program that creates at least one activity of each type.
// Put each of these activities in the same list.
// Then iterate through this list and call the GetSummary method
// on each item and display the results.