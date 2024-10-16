using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


public class Assignment
{
    private string _studentName ="";
    private string _topic = "";


    
    public string GetStudentName()
    {
        return _studentName;
    }
    
    public void SetStudentName(string studentname)
    {
        _studentName = studentname; 
    }

    public string GetTopic()
    {
        return _topic;

    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }



    public string GetSummeryInfo()
    {
        return $"{_studentName} - {_topic}";
    }
}



