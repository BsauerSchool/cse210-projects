using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Video video1 = new Video();
        video1.SetTitle("Mysterious Mysteries");
        video1.SetAuthor("Irkens");
        video1.SetLength(120);
        video1.AddComment("Dib", "I SAW BIGFOOT");
        video1.AddComment("Dib", "I REALLY SAW HIM!!!");
        video1.AddComment("Dib", "BIGFOOT IS FIGHTING THE LOCKNESS MONSTGER!!!");

        // Video 2
        Video video2 = new Video();
        video2.SetTitle("Mysterious Mysteries");
        video2.SetAuthor("Irkens");
        video2.SetLength(121);
        video2.AddComment("Dib", "ZIM IS AN ALIEN");
        video2.AddComment("Dib", "The dog is suspicious too");
        video2.AddComment("Dib", "Humans don't have squeedlyspooch");

        // Video 3
        Video video3 = new Video();
        video3.SetTitle("Mysterious Mysteries");
        video3.SetAuthor("Irkens");
        video3.SetLength(122);
        video3.AddComment("Dib", "ZIM CALLED FOR BACKUP!!!");
        video3.AddComment("Dib", "Nevermind, they left");
        video3.AddComment("Dib", "THEY ARE BACK AGAIN!!!!");
        video3.AddComment("Dib", "....And they're gone again");

        // Video 4
        Video video4 = new Video();
        video4.SetTitle("Mysterious Mysteries");
        video4.SetAuthor("Irkens");
        video4.SetLength(123);
        video4.AddComment("Dib", "Do people even read my comments?");
        video4.AddComment("Dib", "Hello? Is anybody reading these?");
        video4.AddComment("Dib", "Is this a simulation again?");


        DisplayVideo(video1);
        DisplayVideo(video2);
        DisplayVideo(video3);
        DisplayVideo(video4);        
    }

    // Method to print the video info

    public static void DisplayVideo(Video video)
    {
        // Video Info
        Console.WriteLine($"Title: {video.GetTitle()}");
        Console.WriteLine($"Author: {video.getAuthor()}");
        Console.WriteLine($"Video Length: {video.GetLength()}");
        Console.WriteLine();
        Console.WriteLine("COMMENTS");

        // Comments
        Console.WriteLine($"Number of Comments: {video.GetNumberOfComments(video.GetComments())}");
        List<Comment> com = video.GetComments();
        foreach(Comment c in com)
        {
            Console.WriteLine("--------");
            Console.WriteLine($"Commentor: {c.GetName()}");
            Console.WriteLine($"Comment: {c.GetText()}");
            Console.WriteLine("--------");
        }


    }

}


