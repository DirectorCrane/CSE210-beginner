using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop06 World!");

        GoalManager goalManager = new GoalManager();
        int choice;

        

        do
        {   
            Console.Clear();
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            
            
            if (int.TryParse(Console.ReadLine(), out choice))
            { 
                switch (choice)
                {
                case 1:
                    goalManager.CreateNewGoal();
                    break;

                case 2:
                    goalManager.ListGoals();
                    break;

                case 6:
                    Console.WriteLine("Exiting the program. Goodbye! ");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again. ");
                    break;

                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number. ");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

        } while(choice != 6 );
    }
}