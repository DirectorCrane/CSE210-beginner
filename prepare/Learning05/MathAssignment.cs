using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


public class MathAssignment : Assignment
{

    private int _textBookSection;

    private string _problem ="";

        public int GetTextBookSection()
    {
        return _textBookSection;
    }

    public void SetTextBookSection(int textbooksection)
    {
        _textBookSection = textbooksection;
    }

    public string GetProblem()
    {
        return _problem;
    }

    public void SetProblem(string problem)
    {
        _problem = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section:- {_textBookSection} Problem:- {_problem}";
    }






    
}




