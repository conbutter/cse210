using System;

class Program
{
    // Attribute declaration
    private static bool _isRunning = true;
    private static string _userInput;
    private static List<Goal> _goalList = new List<Goal>();
    private static int _totalPoints;

    static void Main(string[] args)
    {
        while ( _isRunning == true )
        {
            Console.WriteLine("\n-+- Goal Tracker Menu -+-\n 1. Create new goal\n 2. List all goals\n 3. Save goals\n 4. Load goals\n 5. Record event\n 6. Quit program\nPlease type the number of the option you wish to select. ");
            _userInput = Console.ReadLine();
            if ( _userInput == "1" ) {
                CreateNewGoal();
            } else if ( _userInput == "2" ) {
                if ( _goalList.Count() != 0 ) {
                    Console.Clear();
                    foreach ( Goal goal in _goalList )
                    {
                        goal.DisplayGoal();
                        Console.WriteLine($"Current Points: {_totalPoints}");
                    }
                } else {
                    Console.WriteLine("There are no goals to display.");
                }
            } else if ( _userInput == "3" ) {
                // Save goals
            } else if ( _userInput == "4" ) {
                // Load goals
            } else if ( _userInput == "5" ) {
                if ( _goalList.Count() != 0 ) {
                    Console.Clear();
                    foreach ( Goal goal in _goalList )
                    {
                        Console.WriteLine($"1. {goal.GetName()}");
                    }
                    Console.WriteLine("\nWhat goal would you like to mark as completed?");
                    _userInput = Console.ReadLine();
                    foreach ( Goal goal in _goalList )
                    {
                        if ( int.Parse(_userInput) == ( _goalList.IndexOf(goal) + 1) )
                        {
                            goal.setCompleted();
                            _totalPoints += goal.GetPoints();
                            Console.WriteLine($"Congrats! You now have {_totalPoints} points.");
                        }
                    }
                } else {
                    Console.WriteLine("There are no goals to record events for!");
                }
            } else if ( _userInput == "6" ) {
                _isRunning = false;
            }
        }
    }

    static void CreateNewGoal()
    {
        int goalType = 0;
        Console.WriteLine("What type of goal would you like to make?\n 1. Simple Goal\n 2. Eternal Goal \n 3. Checklist Goal\nPlease type the number of the option you wish to select.");
        _userInput = Console.ReadLine();
        if ( _userInput == "1" ) {
            goalType = 1;
        } else if ( _userInput == "2" ) {
            goalType = 2;
        } else if ( _userInput == "3" ) {
            goalType = 3;
        }
        Console.WriteLine("Please type the name of the goal:");
        string newGoalName = Console.ReadLine();
        Console.WriteLine("Please type the description of the goal:");
        string newGoalDesc = Console.ReadLine();
        Console.WriteLine("Please type the point value of the goal:");
        int newGoalPoints = int.Parse(Console.ReadLine());
        if ( goalType == 1 ) {
            Goal newSimpleGoal = new SimpleGoal(newGoalName, newGoalDesc, false, newGoalPoints);
            _goalList.Add(newSimpleGoal);
        } else if ( goalType == 2 ) {
            Goal newEternalGoal = new EternalGoal(newGoalName, newGoalDesc, newGoalPoints);
            _goalList.Add(newEternalGoal);
        } else if ( goalType == 3 ) {
            Console.WriteLine("Please type the number of completions required for the bonus:");
            int newGoalNumToComplete = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please type the bonus point value:");
            int newGoalFinishPoints = int.Parse(Console.ReadLine());
            Goal newChecklistGoal = new ChecklistGoal(newGoalName, newGoalDesc, false, newGoalPoints, newGoalNumToComplete, newGoalFinishPoints);
            _goalList.Add(newChecklistGoal);
        }
    }
}