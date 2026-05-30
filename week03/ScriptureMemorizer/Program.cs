using System;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        bool proceed = true;

        Console.WriteLine("");
        Reference ref1 = new Reference("1 Nephi", 3, 7);
        Scripture script1 = new Scripture(ref1, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord givethe no Commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        

        while (proceed == true)
        {
            Console.WriteLine(script1.GetDisplayText());
            Console.WriteLine("Hit Enter to proceed, or type quit to exit");
            string quit = Console.ReadLine();

            if (quit.ToLower() == "quit")
            {
                proceed = false;
            }
            else
            {
                Console.Clear();
                
                int index = 0;
                while(index < 3)
                {
                    if(script1.IsCompletelyHidden() == true)
                    {
                        Console.WriteLine(script1.GetDisplayText());
                        Environment.Exit(0);
                    }
                    else
                    {
                    script1.HideRandomWords();
                    index +=1;
                        
                    }
                } 
                    
                
                
            } 
        }
    }
}