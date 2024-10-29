using System;


public class ReflectionActivity : Activity
{

    
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _question = new List<string>
    {
            "Why was this experience meaningful to you?",
            "Have you done anything like this before?",
            "How did you get started?",
            "How did you feel afterward?",
            "What made this time different from other times?"
    };

    public ReflectionActivity() : base ("\nReflection Activity \n ",
        "This activity helps you reflect on times you showed strength and resilience.\n")
        {}

    public override void PerformActivity()
    {
        Console.WriteLine($"\n {_prompts[new Random().Next(_prompts.Count)]}");
        int timeSeconds = 0;

        int duration = GetDuration();

        while (timeSeconds < duration)
        {
            Console.WriteLine (_question[new Random().Next(_question.Count)]);
            ShowSpinner(10);
            timeSeconds += 3;
        }
    }

    private int GetDuration()
    {
        int duration;
        while(true)
        {
            Console.Write("Enter the duration in seconds: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out duration)&& duration > 0 )
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






