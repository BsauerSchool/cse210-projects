using System;
using System.Runtime.InteropServices;


public class PromptGenerator
{
   public List<string> _prompts = new List<string>();

   public string GetRandomPrompt()
    {
        // ToDo
        Random.Shared.Shuffle(CollectionsMarshal.AsSpan(_prompts));
        string theChosenPrompt = _prompts[_prompts.Count -1];
        _prompts.RemoveAt(_prompts.Count - 1);
        return theChosenPrompt;
    }
}