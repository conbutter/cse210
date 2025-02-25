using System;
using System.ComponentModel;

class ReflectionActivity : Activity
{
    // Attribute declaration

    List<string> _prompts;
    List<string> _questions;

    // Constructor declaration

    public ReflectionActivity(string name, string desc, int duration, List<string> prompts, List<string> questions) : base(name, desc, duration)
    {
        _prompts = new List<string>(prompts);
        _questions = new List<string>(questions);
    }

    // Module declaration

    public void DoActivity()
    {
        // Functionality for core activity loop
    }
}