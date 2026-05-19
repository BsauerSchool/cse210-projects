using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        string filename = file;
        

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e._date}, {e._promptText}, {e._entryText},");
            }          
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }
}