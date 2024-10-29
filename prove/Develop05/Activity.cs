using System;

//ghgh
public class Activity
{
    private string _activityName ;
    private string _description ;
    private int _time ;

    public Activity(string name, string description)
    {
        _activityName = name ;
        _description = description;
    }
     public void Settime(int seconds)
     {
        _time = seconds;
     }

     public void Start()
     {
        Console.WriteLine($"Starting {_activityName}");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _time = int.Parse(Console.ReadLine());
         Console.Clear();
         Console.WriteLine("Get Ready...");
         ShowSpinner(3);
         Console.Clear();

     }

  

     public void ShowSpinner(int seconds)
     {
        for (int i = 0; i < seconds; i++)
        {
        Console.Write("/");
        Thread.Sleep(200);
        Console.Write("\b-");
        Thread.Sleep(200);
        Console.Write("\b\\");
        Thread.Sleep(200);
        Console.Write("\b|");
        Thread.Sleep(200);
        Console.Write("\b");
        }
        
     }
  
        

     public void Finish()
     {
        //Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"You completed{_activityName} for {_time} seconds. ");
        ShowSpinner(20);
        Console.Clear();
    }

    public virtual void PerformActivity() {}



}



