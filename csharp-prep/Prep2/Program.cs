using System;

class Program
{
    static void Main(string[] args)
    {
        
       
        Console.WriteLine ("Welcome to Your Grading Section for Eldorado Sec School");
         
        
        Console.Write("What is your grade percentage? ");
        string StudentPercentage = Console.ReadLine();

        
        int x = int.Parse(StudentPercentage);
        //int y = 80;
        
        //And is &&
        //Or is ||
        //not is !

        //int A = 100 >90;
        //int B = 80 >70;
        //int C = 60 >50;
        //int D = 40 >30;
        //int E = 20 >10;
        //int F = 9 >0;

        if (x >= 90 )

        {
         Console.WriteLine("A");
        }

         else if (x >= 80 )
         {
           Console.WriteLine("B"); 

                   }
         else if (x >= 70 )
         {

           Console.WriteLine("C");
         }

         else if (x >= 60)
         {
           Console.WriteLine("D");
         }

         else if (x < 60)
         {
           Console.WriteLine("E");
         }
         
         else
         {
            Console.WriteLine("Please Enter a Number/digit");
         }
    if (x >= 70)
    {
        Console.WriteLine("Congratulation!!! You have passed this course");

    }
     else if (x < 70)
     {
        Console.WriteLine("Sorry you have failed try again next Semester!");

     }
         

       

       

    }
}