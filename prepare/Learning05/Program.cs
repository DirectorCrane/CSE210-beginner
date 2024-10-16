using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" World!");
        Console.WriteLine("Take me ome!");

        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Precious Kapusha");
        assignment1.SetTopic("Math");
       
       MathAssignment assignment2 = new MathAssignment();
        assignment2.SetStudentName("Fire Fox");
        assignment2.SetTopic("Pure Math");
        assignment2.SetTextBookSection(300);
        assignment2.SetProblem("8-15");

        WritingAssignment assignment3 = new WritingAssignment();
       assignment3.SetStudentName ("Jessica Durem");
       assignment3.SetTopic ("English Novel");
        assignment3.SetTitle("Set the world on fire");

        Console.WriteLine(assignment1.GetSummeryInfo());
        Console.WriteLine(assignment2.GetSummeryInfo());


        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment3.GetSummeryInfo());
        Console.WriteLine(assignment3.GetWritingInformation());
    }





}