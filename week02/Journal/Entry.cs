using System;

public class Entry
{
    private string _prompt;
    private string _date;
    private string _entry;

    // Constructor
    public Entry()
    {
        _prompt = "";
        _date = "0";
        _entry = "";
    }

    // Getters
    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetEntry()
    {
        return _entry;
    }

    // Setters
    public void SetPrompt(string prompt)
    {
        // TODO: Will need to randomize the prompt, no input
        _prompt = prompt;
    }

    public void SetDate(string date)
    {
        // TODO: Will need to pull date automatically, no imput
        _date = date;
    }

    public void SetEntry(string entry)
    {
        _entry = entry;
    }
}