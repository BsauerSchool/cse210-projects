using System;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference = new Reference();
    private string _scripture;

    public Scripture()
    {
        _reference.SetReference("2 Nephi", 2, 27);
        _scripture = "DONT LOOK AT ME!!!!";
    }

    public void SetScripture(string scripture)
    {
        _scripture = scripture;
    }

    public string Script()
    {
        return _scripture;
    }

    public string GetScripture()
    {
        string refDisplay = _reference.GetReference();
        string display = $"{refDisplay}  -  {_scripture}";
        return display;
    }

    

    
    // Add the setReference here!!!

    // scripture to array
    public string[] ScriptureToArray(string scripture)
    {
        string script = scripture;
        string[] words = script.Split(' ');
        return words;
    }

    public int RandomNumber(int length)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, length);
        return number;
    }
    
}