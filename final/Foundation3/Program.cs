using System;

class Program
{
    private static List<Event> _events = new List<Event>();

    static void Main(string[] args)
    {
        // Create events w/ values
        // Display event descriptions for all events
    }
}

// They typically handle a few main types of events:
//     Lectures, which have a speaker and have a limited capacity.
//     Receptions, which require people to RSVP, or register, beforehand.
//     Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.

// Program Specification
// Write a program that has a base Event class along with derived classes for each type of event.
// These classes should contain the necessary data and provide methods to return strings
// for each of the messages the company desires.
// Remember that any data or methods that are common
// among all types of events should be in the base class.
// Once you have the classes in place,
// write a program that creates at least one event of each type
// and sets all of their values.
// Then, for event event, call each of the methods to generate the marketing messages
// and output their results to the screen.

// In addition, your program must:
//     Use inheritance to avoid duplicating shared attributes and methods.
//     Use an address class for the addresses.
//     Follow the principles of encapsulation, making sure each member variable is private.
