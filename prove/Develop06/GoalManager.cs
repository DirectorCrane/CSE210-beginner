using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;



public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int totalPoints = 0;

    public int GetTotalPoints() => totalPoints;
    

    public void CreateNewGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Chacklist Goal ");
        Console.WriteLine("which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal?");
        string name = Console.ReadLine();

        Console.Write("What is short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = goalType switch
        {
            1 => new SimpleGoal(name, description, points),
            2 => new EternalGoal(name, description, points),
            3 => new ChecklistGoal(name, description, points),
            _ => throw new ArgumentException("Invalid goal type")

        };
        goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

        public void ListGoals()
        {
            
            Console.WriteLine("Your Goals:");
            foreach (Goal goal in goals)
            {
                Console.WriteLine($"{goal.GetStatus()} {goal.GetName()}- {goal.GetDescription()} ({goal.GetPoints()}points)");
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("Select a goal to record: ");
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].GetName()} - {goals[i].GetDescription()}");
            }
            Console.Write("Enter the number of goal you completed:");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;
            if (goalIndex >= 0 && goalIndex < goals.Count)
            {
                goals[goalIndex].RecordEvent();
                totalPoints += goals[goalIndex].GetPoints();
                Console.WriteLine($"Event recored! You gained {goals[goalIndex].GetPoints()} points. ");

            } 
            else
            {
                Console.WriteLine("Invalid goal selection." );
            }





        }
    








}




