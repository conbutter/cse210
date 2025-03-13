using System;
using System.Runtime.CompilerServices;

static class GoalManager
{
    // No attribute declaration

    // Module declaration
    public static List<Goal> CreateNewGoal(List<Goal> goalList)
    {
        Console.Clear();
        int goalType = 0;
        Console.Write("What type of goal would you like to make?\n 1. Simple Goal\n 2. Eternal Goal (constant, cannot be marked as completed)\n 3. Checklist Goal (rewards points per step, rewards bonus per full completion)\n 4. Negative Goal (deducts points per event)\nPlease type the number of the option you wish to select. ");
        string userInput = Console.ReadLine();
        if ( int.Parse(userInput) >= 1 && int.Parse(userInput) <= 4 ) {
            goalType = int.Parse(userInput);
        } 
        Console.Write("Please type the name of the goal: ");
        string newGoalName = Console.ReadLine();
        Console.Write("Please type the description of the goal: ");
        string newGoalDesc = Console.ReadLine();
        if ( goalType == 1 ) {
            Console.Write("Please type the point value of the goal: ");
            int newGoalPoints = int.Parse(Console.ReadLine());
            Goal newSimpleGoal = new SimpleGoal(newGoalName, newGoalDesc, false, newGoalPoints);
            goalList.Add(newSimpleGoal);
        } else if ( goalType == 2 ) {
            Console.Write("Please type the point value of the goal: ");
            int newGoalPoints = int.Parse(Console.ReadLine());
            Goal newEternalGoal = new EternalGoal(newGoalName, newGoalDesc, newGoalPoints);
            goalList.Add(newEternalGoal);
        } else if ( goalType == 3 ) {
            Console.Write("Please type the point value of the goal: ");
            int newGoalPoints = int.Parse(Console.ReadLine());
            Console.Write("Please type the number of completions required for the bonus: ");
            int newGoalNumToComplete = int.Parse(Console.ReadLine());
            Console.Write("Now please type the bonus point value: ");
            int newGoalFinishPoints = int.Parse(Console.ReadLine());
            Goal newChecklistGoal = new ChecklistGoal(newGoalName, newGoalDesc, false, newGoalPoints, newGoalNumToComplete, newGoalFinishPoints);
            goalList.Add(newChecklistGoal);
        } else if ( goalType == 4 ) {
            Console.Write("Please type the point value of the goal (this will be deducted for each goal event): ");
            int newGoalPoints = int.Parse(Console.ReadLine());
            Goal newNegativeGoal = new NegativeGoal(newGoalName, newGoalDesc, newGoalPoints);
            goalList.Add(newNegativeGoal);
        }
        Program.SetUnsaved();
        Console.Clear();
        Console.WriteLine($"The goal '{newGoalName}' has been created!");
        return goalList;
    }
    
    public static void ListGoals(List<Goal> goalList, int totalPoints)
    {
        Console.Clear();
        if ( goalList.Count() != 0 ) {
            Console.Clear();
            foreach ( Goal goal in goalList )
            {
                goal.DisplayGoal();
            }
            Console.WriteLine($"Current Points: {totalPoints}");
        } else {
            Console.WriteLine("There are no goals to display.");
        }
    }

    public static List<Goal> DeleteGoal(List<Goal> goalList)
    {
        Console.Clear();
        if ( goalList.Count() != 0 ) {
            Console.Clear();
            foreach ( Goal goal in goalList )
            {
                Console.WriteLine($"{goalList.IndexOf(goal) + 1}. {goal.GetName()}");
            }
            Console.Write("\nPlease type the number of the goal you would like to delete; type 0 to cancel: ");
            string userInput = Console.ReadLine();
            bool goalRemoved = false;
            int goalRemoveIndex = 0;
            string removedGoalName = "";
            foreach ( Goal goal in goalList )
            {
                if ( int.Parse(userInput) == ( goalList.IndexOf(goal) + 1) )
                    {
                        goalRemoveIndex = goalList.IndexOf(goal);
                        removedGoalName = goal.GetName();
                        goalRemoved = true;
                    }
            }
            if ( goalRemoved == true )
            {
                goalList.RemoveAt(goalRemoveIndex);
                Console.Clear();
                Console.WriteLine($"Goal '{removedGoalName}' has been deleted.");
                Program.SetUnsaved();
                goalRemoved = true;
            } else {
                Console.Clear();
                Console.WriteLine("Goal deletion cancelled; no changes were made.");
            }
        } else {
            Console.Clear();
            Console.WriteLine("There are no goals to delete!");
        }
        return goalList;
    }
    
}