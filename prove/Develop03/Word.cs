using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Word

{
    private string _text;
    private bool _isHidden;
    
    public Word(string wordtext)
    {
        _text = wordtext;
        _isHidden = false ;

    }
    public void Hide()
    {
        _isHidden = true;
    }
    

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden?"___":_text ;
    }

    
}