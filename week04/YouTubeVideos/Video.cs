using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();


    public void SetTitle(string title)
    {
       _title = title; 
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string getAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void AddComment(string name, string text)
    {
        Comment comment = new Comment();
        comment.SetName(name);
        comment.SetText(text);

        _comments.Add(comment);
    }

    public int GetNumberOfComments(List<Comment> comments)
    {
        int numberOfComments = comments.Count;
        return numberOfComments;
    }
    
}