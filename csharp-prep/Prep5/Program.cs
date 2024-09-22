using System;

class Program
{
    static void Main(string[] args)
   
    {
         //static void DisplayMessage()
       {
        DisplayWelcomeMassage();

        string NameUser = PromptName();
        int NumberUser = PromptNumber();
        int squareNumber =SquareNumber(NumberUser);

        //string userName = PromptUserName();
        //int userNumber = PromtUserNumber();
        
        DisplayResult(NameUser, squareNumber);
        //Console.Write("Please enter your name: {UserName}");
       }

        static void DisplayWelcomeMassage()

        {
            Console.WriteLine("Welcome to the program! ");
        }

        static string PromptName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptNumber()

        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)

        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)

        {
          Console.WriteLine($"{name}, the square of your number is {square}"); 
        }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}