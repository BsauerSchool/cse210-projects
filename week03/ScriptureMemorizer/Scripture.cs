using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> splitText = new List<string>();
        splitText = text.Split(" ").ToList();

        foreach(string txt in splitText)
        {
            Word word = new Word(txt);
            _words.Add(word);
        }
    }

    public string GetDisplayText()
    {
        string refer = _reference.GetDisplayText();
        string sentance = "";
        foreach(Word wrd in _words)
        {
            string txt = wrd.GetDisplayText();
            sentance += txt + " ";
        }
        return $"{refer} \n{sentance}.";
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int numberToHide = random.Next(0, _words.Count());

        bool alreadyHidden = _words[numberToHide].IsHidden();

        while(alreadyHidden == true)
        {
            numberToHide = random.Next(0, _words.Count());
            alreadyHidden = _words[numberToHide].IsHidden();
        }

        if (alreadyHidden == false)
        {
            _words[numberToHide].Hide();
        }
        

    }

    public bool IsCompletelyHidden()
    {
        foreach( Word wrd in _words)
        {
            if (wrd.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
    
}