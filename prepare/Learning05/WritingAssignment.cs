using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class WritingAssignment : Assignment
{
    private string _title = "";

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"Title: {_title}";
    }




}






