using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator prompts = new PromptGenerator();
        prompts._prompts.Add("Who was the most interesting person I interacted with today?");
        prompts._prompts.Add("What was the best part of my day?");
        prompts._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts._prompts.Add("What was the strongest emotion I felt today?");
        prompts._prompts.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();

       
        bool quit = false;
        while (quit == false)
        {
            string choice;
            string file;
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry._promptText = prompts.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);
                    entry._entryText = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    entry._date = theCurrentTime.ToShortDateString();
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.WriteLine("Wah is the filename?");
                    file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    break;

                case "4":
                    Console.WriteLine("What is the filename?");
                    file = Console.ReadLine();
                    journal.SaveToFile(file);
                    break;

                case "5":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Incorrect");
                    break;
            }  
        }
    }
}
