using System;

public class ListingActivity : Activity
{
    private List<string>  _2prompts = new List<string> 
    {
            "Who are people you appreciate?",
            "What are your personal strengths?",
            "Who have you helped this week?",
            "When have you felt inspired recently?",
            "Who are some of your personal heroes?"

    };

    public ListingActivity() : base("\nListing Activity\n",
        "This activity helps you list good things in your life in a specific area.\n")
        {}

    public override void PerformActivity()
    {   
        int duration = GetDuration();
        //int secondsPassed = 0;
        int itemsListed = 0;

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);

        Console.WriteLine($"\n{_2prompts[new Random().Next(_2prompts.Count)]}");
        Console.WriteLine("You have a few seconds to think...");

        // ShowSpinner(3);
        // int itemCount = 0;  .AddSeconds(GetDuration())
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemsListed++;

        }
        Console.WriteLine ($"Good job! You've listed {itemsListed} items!");
        ShowSpinner(10);

    }
    private int GetDuration()
    {
        int duration;
        while(true)
        {
            Console.Write ("Enter the duarion in seconds; ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out duration )&& duration > 0)
            {
                return duration;

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0. ");
            }


        }



    }

    





    
}










