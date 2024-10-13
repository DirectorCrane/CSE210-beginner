using System;

class Program
{
    static void Main(string[] args)
    {
       Reference reference = new Reference("Proverbs", 3, 5, 6);
       string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."; 
       Scripture scripture = new Scripture(reference, scriptureText);

       Console.Clear();
       scripture.Display();

       while (true)
       {
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string input = Console.ReadLine();
        if (input == "quit")
        {
            break;
        }
        scripture.HideWords();
        scripture.Display();

        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("Program Ended All words are hidden");
            break;
        }


       }

       
       
        //Reference note = new Reference();
        //note.DisplayRef();
       //Console.WriteLine({_words});
        //notebook.Record();
        
    
    
    
    
    
    }
}