using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


public class Journal
{
    public string _title;
    public string _title2;
    public string _pick;

    public string _write;

    public string _display;
    public string _load;

    public string _save;
    public string _quit; 

    public void Record()
    {
    //Console.WriteLine($"{_title}\n{_title2}\n{_write}\n{_display}\n{_load}\n{_save}\n{_quit}");
    //Console.Write(_pick);
    }

       List<string> questions = new List<string>()
                 {
                     "What was the best part of my Day?",
                    "What did I learn from my scripture study today?",
                    "What negative feelings did I experience today?",
                    "What is one goal I worked on today? how did I progress",
                     "How did I connect with family or friends today?",
                 };

     public void Run()
    {
       
                //to store the list of questions
              

                //This is where the users store answers
                List<string> userAnswers = new List<string>();
                 
                 //give a random question

                 //List<string> currentQuestion = new list<string>();
                
                bool running = true;
                 
                 
                while (running)
                {
                    Console.WriteLine($"{_title}\n{_title2}\n{_write}\n{_display}\n{_load}\n{_save}\n{_quit}");
                    Console.Write($"{_pick}");
                    
                
                    string choice =Console.ReadLine();
                if (choice == "1")  
                    { 
                    if (questions.Count > 0)
                    {
                        Random random = new Random();
                       
                        int index = random.Next(questions.Count);

                        string currentQuestion = questions[index];
                        
                        Console.WriteLine(currentQuestion);
                        
                        
                        string userAnswer = Console.ReadLine();
                        userAnswers.Add($"{currentQuestion}: {userAnswer}");
                        
                        

                        questions.RemoveAt(index);
                    }
                    }

                 if (choice == "2")
                 {
                    if (userAnswers.Count > 0)
                    {
                        DateTime currentDate = DateTime.Now;
                        //Console.WriteLine($"\n{currentDate}: {answer}\n");
                          foreach (string answer in userAnswers)
                          {
                        Console.WriteLine($"\n{currentDate}: {answer}\n");
                          }
                    }

                 }

                 if (choice == "3")
                {
                  
                  string filePath = "journal.txt";
                   string content = File.ReadAllText(filePath);
                   Console.WriteLine(content);
                  
                }  
                 if (choice == "4")
                   {
                    string filePath = "journal.txt";
                    string dataToSave = "Enty for Journal";
                    File.WriteAllText(filePath, dataToSave);
                    Console.WriteLine("File has been saved");
                   } 


                   else if (choice == "5")
                     {
                 running = false;
                        
                     }
                }    
                 
                
        
    }




   
}