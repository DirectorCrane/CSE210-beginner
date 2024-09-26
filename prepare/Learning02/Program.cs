using System;
using System.Security.Cryptography.X509Certificates;


class Program
{
      static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

         
         Job job1 = new Job();
         job1._company = "Apple"; 
         job1._jobTitle = "Software Engineer";
         job1._startYear = 1950;
         job1._endYear = 2005;

         Job job2 = new Job ();
         job2._company = "MicroSoft"; 
         job2._jobTitle = "Front end web developer";
         job2._startYear = 2019;
         job2._endYear = 2023;

         //int _jobs = 0;

         Resume resume1 = new Resume();
         resume1._name = "Ethan Izaaks";
         resume1._jobs.Add(job1);
         resume1._jobs.Add(job2);
        
        
         job1.Employment();
         resume1.Career();
    }
}