using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{

    private Reference reference;
    private List<Word> words;
   


    public Scripture(Reference scriptureReference, string scriptureText)

    {
        reference = scriptureReference;
        words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(string.Join(" ", words.Select(word => word.GetDisplayText())));

    }

    public void HideWords()
    {
        Random random = new Random();
        int wordsToHide = random.Next(1, 4);
        int hiddenCount = 0;
        
        while (hiddenCount < wordsToHide)
        {
            int index = random.Next(words.Count);
            if (!words [index].IsHidden())
            {
                words[index].Hide();
                hiddenCount++;
            }

        }

    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }


















   











}
