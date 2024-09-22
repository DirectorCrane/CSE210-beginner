using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int> ();
        
        Console.WriteLine("Welcome to a list game for numbers.");
        //using System.Collections.Generic;
        int userNumber = -1;
         while (userNumber != 0)
         {
       
          
      
          Console.Write("Enter a list of numbers, type 0 when finished:");
           
           string entry = Console.ReadLine();

           userNumber = int.Parse (entry);

           if (userNumber != 0)
           {
             numbers.Add(userNumber);

           }

         }
         
          //total numbers of in the list
         
     int total = 0;

     int sumTotal = 0;

     int largest = 0; 

      foreach (int number in numbers)

         {
          total += number;
         

          Console.WriteLine($"The Total is: {total}");

          //Calculate the average

          //sum =  total += total / numbers.Count;
          //double average = (double)total / numbers.Count;
          sumTotal = total / numbers.Count;

          Console.WriteLine($"The average is: {sumTotal}");

         if (number > largest)
                {
                   largest = number;
                }

             Console.WriteLine($"The largest number is: {largest}");

         }

          



         

        
     
     
     

     //List<int> numbers = new List<int> ();

     //numbers.Add("100");
     //numbers.Add("50");
     //numbers.Add("10");



    }
}