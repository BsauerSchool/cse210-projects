using System;
using System.Collections.Generic;
using System.IO;    

class Program
{
    static void Main(string[] args)
    {
        
        // string filename = "week02/Journal/prompts.csv";
        // string[] lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split(",");
            
        //     string prompt = parts[0];

        //     Console.WriteLine(prompt);
        //     Console.WriteLine(line);
        // }

        // Console.WriteLine("Hello World! This is the Journal Project.");

        Entry firstEntry = new Entry();
        firstEntry.SetPrompt("This is a prompt~");
        firstEntry.SetDate("32026~");
        firstEntry.SetEntry("Entry 1~");

        Entry secondEntry = new Entry();
        secondEntry.SetPrompt("This is the second prompt~");
        secondEntry.SetDate("32126~");
        secondEntry.SetEntry("Entry 2");

        List<Entry> entries = new List<Entry>();
        entries.Add(firstEntry);
        entries.Add(secondEntry);

        



        SaveToFile(entries);
        ReadFromFile();

    }

    public static void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("Saving to File");

        string filename = "/home/dranger09/Documents/School/cse210/cse210-projects/week02/Journal/entries.csv";
        
        using (StreamWriter outputFile = new StreamWriter(filename, false))
        {
            foreach (Entry entry in entries)
            { 
                outputFile.WriteLine(entry.GetDate());
                outputFile.WriteLine(entry.GetPrompt());
                outputFile.WriteLine(entry.GetEntry());
                outputFile.WriteLine("TEST");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {   
        Console.WriteLine("Reading From File");
        List<Entry> entries = new List<Entry>();
        string fileName = "/home/dranger09/Documents/School/cse210/cse210-projects/week02/Journal/entries.csv";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {

            Console.WriteLine(line);
            // string[] part = line.Split("~");
            // Console.WriteLine($"Date: {part[0]}");
            // Console.WriteLine($"Prompt: {part[1]}");
            // Console.WriteLine($"Entry: {part[2]}");
        }

        return entries;
    }
}

//CSE210-PROJECTS/week02/Journal/entries.csv
///home/dranger09/Documents/School/cse210/cse210-projects/week02/Journal/entries.csv

// 1. New Entry
//     - Shows a random prompt to the user from a list in a csv file
//     - save their response, prompt, and date as entry

// 2. Display the journal - iterate through all entries in the journal and dsplay them to the screen

// 3. Save the journal to a file - prompt the user for a filename and then save the current journal (the complete list of entries) to that location.

// 4. Load the journal from a file - prompt the user for a filename then load the journal from that file. This should replace any entries curently stored.

// 5. Provide a menu that allows the user to choose these options.

// 6. Yourlist of prompts must contain at least five different prompts. Make sure to add your own prompts to the list.

// 7. Your interface should generally follow the pattern in the video.

// contain classes for the major components
// Contain at least two classes in addition to the program class
// demonstrate abstraction by using member variables and methods appropriately.