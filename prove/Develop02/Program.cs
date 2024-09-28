using System;

class Program
{
    static void Main(string[] args)
    {

        Journal notebook = new Journal();
        notebook._title = "Welcome to the Journal Program"; 
        notebook._title2 = "Please select one of the following choices: ";
        notebook._pick = "What would you like to do?\n> ";
        notebook._write = "1. Write" ; 
        notebook._display = "2. Display" ;
        notebook._load = "3. Load";
        notebook._save= "4. Save" ; 
        notebook._quit = "5. Quit" ;
        
        
        
        notebook.Record();
        notebook.Run();

        
    }
}