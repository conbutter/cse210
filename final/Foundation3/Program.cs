using System;

class Program
{
    private static List<Event> _events = new List<Event>();

    static void Main(string[] args)
    {
        // Create events w/ values
        Lecture lecture1 = new Lecture("Designing Thrills in Digital Software", 
        "A comprehensive look at how to use programs to structure ride layouts..", 
        "May 5th, 2025", "5:00 PM",
        "5315 Hemmingway Park", "Saltsville", "TN", "USA",
        "Harmond Row", 1975);
        _events.Add(lecture1);
        Reception reception1 = new Reception("Homecoming of Elder Jacobsen", 
        "Celebrate the completion of Elder Mark Jacobsen's mission with us!", 
        "August 8th, 2025", "3:00 PM",
        "Trotwood Park", "Oviedo", "FL", "USA",
        "totallyarealemail@emailservice.com");
        _events.Add(reception1);
        Gathering gathering1 = new Gathering("165th Fantasy Meetup", 
        "Fantasy fans of all types, gather together to play D&D and meet some new friends!", 
        "August 8th, 2025", "3:00 PM",
        "Central Ampitheater", "Liverpool", "L1 1AB", "UK",
        "25% chance of rain; shelter will be provided.");
        _events.Add(gathering1);

        // Display event descriptions for all events
        foreach ( Event e in _events )
        {
            Console.WriteLine($"\n>>> EVENT NUMBER {_events.IndexOf(e) + 1} \n--- [ Standard Description ] ---");
            e.DisplayStandard();
            Console.WriteLine($"--- [ Full Description ] ---");
            e.DisplayFull();
            Console.WriteLine($"--- [ Short Description ] ---");
            e.DisplayShort();
            if ( _events.Count() == ( _events.IndexOf(e) + 1 ) )
            {
                Console.WriteLine();
            }
        }
    }
}