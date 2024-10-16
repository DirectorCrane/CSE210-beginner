using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


public class Comment
{
    public string _name;
    
    
    public string _text;

    public Comment (string name, string text)
{
    _name = name;
    _text = text;

}

    public void DisplayCommentInfo()
    {
        //Console.WriteLine("review");
                
            Console.WriteLine($"Name:{_name}");
            Console.WriteLine($"Comment: {_text}");
        
    }
}





