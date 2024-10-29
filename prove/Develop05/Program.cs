using System;

class Program
{
    static void Main(string[] args)
    {
       
     Dictionary<string, Activity> activities = new Dictionary<string, Activity>
     {
        {"1", new BreathingActivity() },
        {"2", new ReflectionActivity() },
        {"3", new ListingActivity() }

     };

     while (true)
     {

        Console.WriteLine("\nMenu Options: ");
        Console.WriteLine("1. Breathing Activity ");
        Console.WriteLine("2. Reflection Activity ");
        Console.WriteLine("3. Listing Activity ");
        Console.WriteLine("4, Quit ");

        Console.Write("Please select a choice from the Menu: ");
        string choice = Console.ReadLine();
        Console.Clear();

        if (choice == "4")
        {

            Console.WriteLine("Goodbye!.....");
            break;
        }
        else if (activities.ContainsKey(choice))
        {
            Activity activity = activities[choice];
            activity.Start();
            activity.PerformActivity();
            activity.Finish();

        }
        else
        {
            Console.WriteLine("Invalid choice, please try again. ");
        }













     }

    

        
        
        
        
        
       
      
    }
}