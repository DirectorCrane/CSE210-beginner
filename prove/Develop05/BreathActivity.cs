using System;

public class BreathingActivity : Activity
{
    

    public BreathingActivity() : base ("\n Breathing Activity \n",
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n")
    {}

    public override void PerformActivity()
    {

        int duration = GetDuration();
        int timeSeconds = 0;

        Console.WriteLine("Prepare to begin ");
        ShowSpinner(10);


        while (timeSeconds < duration )
        {
            Console.WriteLine("\nBreathe in...");
            ShowCountdown(3);
            timeSeconds += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            timeSeconds += 3;

        }
       // Console.WriteLine("Good Job! You've completed the breathing activity. ");
        ShowSpinner(3);
    }

    private int GetDuration()
    {
        int duration;
        while (true)
        {
            Console.Write("Enter the duartion in Seconds: ");
            string input = Console.ReadLine();

            if (int.TryParse (input, out duration)&& duration > 0)
            {
                return duration; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 0. ");
            }





        }




    }


    private void ShowCountdown (int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000); 
        }
        Console.WriteLine();

    }
    


}




