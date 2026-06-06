using System;
using System.Runtime.CompilerServices;

public class Comment
{
    private string _name;
    private string _text;

    public Comment()
    {
        _name = "";
        _text = "";
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetText()
    {
        return _text;
    }
}