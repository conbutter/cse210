using System;

class Program
{
    // Attribute declaration
    private static bool _isRunning = true;
    private static string _userInput;
    private static List<Goal> _goalList = new List<Goal>();
    private static int _totalPoints;
    private static bool _unsavedChanges = false;

    static void Main(string[] args)
    {
        Console.Clear();
        while ( _isRunning == true )
        {
            Console.Write("\n-+- Goal Tracker Menu -+-\n 1. Create new goal\n 2. List all goals\n 3. Save goals\n 4. Load goals\n 5. Record event\n 6. Quit program\nPlease type the number of the option you wish to select. ");
            _userInput = Console.ReadLine();
            if ( _userInput == "1" ) {
                CreateNewGoal();
                _unsavedChanges = true;
            } else if ( _userInput == "2" ) {
                ListGoals();
            } else if ( _userInput == "3" ) {
                SaveGoals();
            } else if ( _userInput == "4" ) {
                UnsavedCheck();
                LoadGoals();
            } else if ( _userInput == "5" ) {
                RecordEvent();
                _unsavedChanges = true;
            } else if ( _userInput == "6" ) {
                UnsavedCheck();
                _isRunning = false;
                Console.Clear();
            }
        }
    }

    static void CreateNewGoal()
    {
        Console.Clear();
        int goalType = 0;
        Console.Write("What type of goal would you like to make?\n 1. Simple Goal\n 2. Eternal Goal \n 3. Checklist Goal\nPlease type the number of the option you wish to select. ");
        _userInput = Console.ReadLine();
        if ( _userInput == "1" ) {
            goalType = 1;
        } else if ( _userInput == "2" ) {
            goalType = 2;
        } else if ( _userInput == "3" ) {
            goalType = 3;
        }
        Console.Write("Please type the name of the goal: ");
        string newGoalName = Console.ReadLine();
        Console.Write("Please type the description of the goal: ");
        string newGoalDesc = Console.ReadLine();
        Console.Write("Please type the point value of the goal: ");
        int newGoalPoints = int.Parse(Console.ReadLine());
        if ( goalType == 1 ) {
            Goal newSimpleGoal = new SimpleGoal(newGoalName, newGoalDesc, false, newGoalPoints);
            _goalList.Add(newSimpleGoal);
        } else if ( goalType == 2 ) {
            Goal newEternalGoal = new EternalGoal(newGoalName, newGoalDesc, newGoalPoints);
            _goalList.Add(newEternalGoal);
        } else if ( goalType == 3 ) {
            Console.Write("Please type the number of completions required for the bonus: ");
            int newGoalNumToComplete = int.Parse(Console.ReadLine());
            Console.Write("Now please type the bonus point value: ");
            int newGoalFinishPoints = int.Parse(Console.ReadLine());
            Goal newChecklistGoal = new ChecklistGoal(newGoalName, newGoalDesc, false, newGoalPoints, newGoalNumToComplete, newGoalFinishPoints);
            _goalList.Add(newChecklistGoal);
        }
        Console.Clear();
        Console.WriteLine($"The goal '{newGoalName}' has been created!");
    }

    static void ListGoals()
    {
        Console.Clear();
        if ( _goalList.Count() != 0 ) {
            Console.Clear();
            foreach ( Goal goal in _goalList )
            {
                goal.DisplayGoal();
            }
            Console.WriteLine($"Current Points: {_totalPoints}");
        } else {
            Console.WriteLine("There are no goals to display.");
        }
    }

    static void SaveGoals()
    {
        if ( _goalList.Count() != 0 )
        {
            Console.Write("Please give the goals file a name to be saved as (do NOT include .txt): ");
            string filename = Console.ReadLine() + ".txt";
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_totalPoints);
                foreach ( Goal goal in _goalList )
                {
                    if ( goal is SimpleGoal ) {
                        outputFile.WriteLine($"SimpleGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.IsCompleted()}|{goal.GetPoints()}");
                    } else if ( goal is EternalGoal ) {
                        outputFile.WriteLine($"EternalGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}");
                    } else if ( goal is ChecklistGoal ) {
                        ChecklistGoal ChecklistGoalForSave = (ChecklistGoal)goal;
                        outputFile.WriteLine($"ChecklistGoal|{ChecklistGoalForSave.GetName()}|{ChecklistGoalForSave.GetDescription()}|{ChecklistGoalForSave.IsCompleted()}|{ChecklistGoalForSave.GetPoints()}|{ChecklistGoalForSave.GetNumberToComplete()}|{ChecklistGoalForSave.GetFinishPoints()}");
                    }
                }
                Console.Clear();
                Console.WriteLine($"Goals saved under filename '{filename}'.");
            _unsavedChanges = false;
            }
        } else {
            Console.Clear();
            Console.WriteLine("There are no goals to save! Try adding a goal or loading a file.");
        }
    }

    static void LoadGoals()
    {
        Console.Write("Please type the name you want the file you want to load (do NOT include .txt): ");
        string filename = Console.ReadLine() + ".txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int goals_loaded = 0;
        for (int i = 1; i < lines.Length; i++)
        {
            goals_loaded += 1;
            _totalPoints = int.Parse(lines[0]);
            string[] parts = lines[i].Split("|");
            if ( parts[0] == "SimpleGoal" )
            {
                string goal_name = parts[1];
                string goal_desc = parts[2];
                bool goal_completedstatus = bool.Parse(parts[3]);
                int goal_points = int.Parse(parts[4]);
                Goal newSimpleGoal = new SimpleGoal(goal_name, goal_desc, goal_completedstatus, goal_points);
                _goalList.Add(newSimpleGoal);
            } else if ( parts[0] == "EternalGoal" )
            {
                string goal_name = parts[1];
                string goal_desc = parts[2];
                int goal_points = int.Parse(parts[3]);
                Goal newEternalGoal = new EternalGoal(goal_name, goal_desc, goal_points);
                _goalList.Add(newEternalGoal);
            } else if ( parts[0] == "ChecklistGoal" )
            {
                string goal_name = parts[1];
                string goal_desc = parts[2];
                bool goal_completedstatus = bool.Parse(parts[3]);
                int goal_points = int.Parse(parts[4]);
                int goal_numtocomplete = int.Parse(parts[5]);
                int goal_finishpoints = int.Parse(parts[6]);
                Goal newChecklistGoal = new ChecklistGoal(goal_name, goal_desc, goal_completedstatus, goal_points, goal_numtocomplete, goal_finishpoints);
                _goalList.Add(newChecklistGoal);
            }
        }
        Console.Clear();
        Console.WriteLine($"{goals_loaded} goals loaded from '{filename}'.");
    }

    static void RecordEvent()
    {
        Console.Clear();
        if ( _goalList.Count() != 0 ) {
            Console.Clear();
            foreach ( Goal goal in _goalList )
            {
                Console.WriteLine($"{_goalList.IndexOf(goal) + 1}. {goal.GetName()}");
            }
            Console.Write("\nPlease type the number of the goal you would like to mark as completed: ");
            _userInput = Console.ReadLine();
            foreach ( Goal goal in _goalList )
            {
                if ( int.Parse(_userInput) == ( _goalList.IndexOf(goal) + 1) )
                {
                    if ( goal.IsCompleted() == true )
                    {
                        Console.Clear();
                        Console.WriteLine("This goal has already been completed; no new points can be awarded.");
                    } else {
                        goal.SetCompleted();
                        _totalPoints += goal.GetPoints();
                        Console.Clear();
                        Console.WriteLine($"Congrats! You now have {_totalPoints} points.");
                    }
                }
            }
        } else {
            Console.Clear();
            Console.WriteLine("There are no goals to record events for!");
        }
    }

    static void UnsavedCheck()
    {
        if ( _unsavedChanges == true ) 
            {
                Console.Write($"--[!]-- WARNING --[!]--\nYour current goal list has unsaved changes!\nWould you like to save your current list first? (y/n) ");
                _userInput = Console.ReadLine();
                if ( _userInput == "y" )
                {
                    SaveGoals();
                    Console.WriteLine("Goals saved.");
                }
            }
    }
}