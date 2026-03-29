using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference()
    {
        _book = "";
        _chapter = 0;
        _verse = 0;
    }

    public void SetReference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetReference()
    {
        string display = $"{_book}: {_chapter}:{_verse}";
        return display;
    }
}