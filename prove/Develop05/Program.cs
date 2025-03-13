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
            Console.Write("\n-+- Goal Tracker Menu -+-\n 1. Create new goal\n 2. List all goals\n 3. Save goals\n 4. Load goals\n 5. Record event\n 6. Delete goal\n 7. Quit program\nPlease type the number of the option you wish to select. ");
            _userInput = Console.ReadLine();
            if ( _userInput == "1" ) {
                _goalList = GoalManager.CreateNewGoal(_goalList);
            } else if ( _userInput == "2" ) {
                GoalManager.ListGoals(_goalList, _totalPoints);
            } else if ( _userInput == "3" ) {
                SaveGoals();
            } else if ( _userInput == "4" ) {
                UnsavedCheck();
                LoadGoals();
            } else if ( _userInput == "5" ) {
                GoalManager.RecordEvent(_goalList, _totalPoints);
                _unsavedChanges = true;
            } else if ( _userInput == "6" ) {
                GoalManager.DeleteGoal(_goalList);
            } else if ( _userInput == "7" ) {
                UnsavedCheck();
                _isRunning = false;
                Console.Clear();
            }
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
                    } else if ( goal is NegativeGoal ) {
                        outputFile.WriteLine($"NegativeGoal|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}");
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
        int goalsLoaded = 0;
        for (int i = 1; i < lines.Length; i++)
        {
            goalsLoaded += 1;
            _totalPoints = int.Parse(lines[0]);
            string[] parts = lines[i].Split("|");
            if ( parts[0] == "SimpleGoal" )
            {
                string goalName = parts[1];
                string goalDesc = parts[2];
                bool goalCompletedstatus = bool.Parse(parts[3]);
                int goalPoints = int.Parse(parts[4]);
                Goal newSimpleGoal = new SimpleGoal(goalName, goalDesc, goalCompletedstatus, goalPoints);
                _goalList.Add(newSimpleGoal);
            } else if ( parts[0] == "EternalGoal" )
            {
                string goalName = parts[1];
                string goalDesc = parts[2];
                int goalPoints = int.Parse(parts[3]);
                Goal newEternalGoal = new EternalGoal(goalName, goalDesc, goalPoints);
                _goalList.Add(newEternalGoal);
            } else if ( parts[0] == "ChecklistGoal" )
            {
                string goalName = parts[1];
                string goalDesc = parts[2];
                bool goalCompletedstatus = bool.Parse(parts[3]);
                int goalPoints = int.Parse(parts[4]);
                int goalNumtocomplete = int.Parse(parts[5]);
                int goalFinishpoints = int.Parse(parts[6]);
                Goal newChecklistGoal = new ChecklistGoal(goalName, goalDesc, goalCompletedstatus, goalPoints, goalNumtocomplete, goalFinishpoints);
                _goalList.Add(newChecklistGoal);
            } else if ( parts[0] == "NegativeGoal")
            {
                string goalName = parts[1];
                string goalDesc = parts[2];
                int goalPoints = int.Parse(parts[3]);
                Goal newNegativeGoal = new NegativeGoal(goalName, goalDesc, goalPoints);
                _goalList.Add(newNegativeGoal);
            }
        }
        Console.Clear();
        Console.WriteLine($"{goalsLoaded} goals loaded from '{filename}'.");
    }

    public static void AdjustPoints(int addPoints, bool negative)
    {
        if ( negative == true ) {
            _totalPoints -= addPoints;
        } else {
            _totalPoints += addPoints;
        }
    }

    public static void SetUnsaved()
    {
        _unsavedChanges = true;
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

    public static bool VerifyInput(string input)
    {
        if (int.TryParse(input, out int number) == true)
            {
                return true;
            } else {
                return false;
            }
                
    }
}