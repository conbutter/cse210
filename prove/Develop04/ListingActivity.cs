using System;
using System.ComponentModel;

class ListingActivity : Activity
{
    // Attribute declaration

    List<string> _prompts;

    // Constructor declaration

    public ListingActivity(string name, string desc, int duration, List<string> prompts) : base(name, desc, duration)
    {
        _prompts = new List<string>(prompts);
    }

    // Module declaration

    public void DoActivity()
    {
        // Functionality for core activity loop
    }
}