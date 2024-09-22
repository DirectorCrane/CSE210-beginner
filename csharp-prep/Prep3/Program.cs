using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic Number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
         //Console.WriteLine(userinPut   ); 
         
         Random randomGenerator = new Random();
         int magicNumber= randomGenerator.Next(1, 101);
         
         int guess = -1;

        //  int number = int.Parse(userinPut);

        //Console.WriteLine($"What is your guess? {number}" );
       
while (guess != magicNumber)
   {  
      
       
          Console.Write("What is your guess? ");
          guess = int.Parse(Console.ReadLine());
        //Console.WriteLine("You guessed it!");
       
         if (magicNumber > guess) 
         {
          Console.WriteLine("Higher");
         }
        

        else if (magicNumber < guess)
        {
          Console.WriteLine("Lower");
        }

        else
       
       {
       Console.WriteLine("You guessed it!");
       }

       }
   
    }
}