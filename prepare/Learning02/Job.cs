using System;
using System.Security.Cryptography.X509Certificates;


public class Job
{

public string _company;
public string _jobTitle;
public int _startYear;
public int _endYear;

public void Employment()
{
 Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} ");
 //"Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
}

}






