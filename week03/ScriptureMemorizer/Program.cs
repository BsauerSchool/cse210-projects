using System;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        string response;
        

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Scripture scripture = new Scripture();
        Console.WriteLine(scripture.GetScripture());

        scripture.SetScripture("Check it out");
        Console.WriteLine(scripture.GetScripture());

        string[] words = scripture.ScriptureToArray(scripture.Script());
        //int[] unUsedIndexes = Enumerable.Range(0, words.Length).ToArray();
        List<int> unUsedIndexes = Enumerable.Range(0, words.Length).ToList();
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(unUsedIndexes));
        // Loop Enter or quit
        while ( quit != true)
        {
            

            Console.WriteLine("Hit Enter or type Quit");
            response = Console.ReadLine().ToLower();
            bool finished = false;


            if (response == "quit" || finished == true)
            {
                // quit = true;
                System.Environment.Exit(0);
            }
            else
            {   
                if (unUsedIndexes.Count == 0)
                {
                    System.Environment.Exit(0);

                }
                else
                {
                    
                    int index = unUsedIndexes.Count - 1;
                    // TODO: swap the characters at that index to ----
                    Console.WriteLine(words[index]);
                    foreach(char a in words[index])
                    {
                        
                    }

                    words[index].Replace(words[index], "-");
                    Console.WriteLine(words[index]);

                     // Removing the last item in the randomized list.!!!!!!
                    unUsedIndexes.RemoveAt(unUsedIndexes.Count - 1);

                }
               

                                
                
                Console.WriteLine(string.Join(", ", words));

            }
        }

    }
    public string HideWord(int index, string word)
    {
        string newWord = word.Replace(word,"-");
        return newWord;
    }
}