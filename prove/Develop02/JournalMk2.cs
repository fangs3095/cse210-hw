using System;
using System.Collections.Generic;

class JournalMk2
{
    public string userInput;
    public string prompt;
    public string date;
    public List<string> entryList = new List<string>();
    PromptGenerator promptGenorator = new PromptGenerator();
    FileHandling fileHandling = new FileHandling();

    public void addEntry()
    {
    
    Console.WriteLine("Enter the curent date");
    date = Console.ReadLine();
    entryList.Add(date);
    prompt = PromptGenerator.getPrompt();
    Console.WriteLine(prompt);
    entryList.Add(prompt);
    userInput = Console.ReadLine();
    entryList.Add(userInput);
    }

    public void display()
    {
        for (int i = 0; i < entryList.Count; i += 3)
        Console.WriteLine("Your writing: " + entryList[i]);
        Console.WriteLine("Date: " + entryList[i + 1]);
        Console.WriteLine("Journal Prompt" + entryList[i + 2]);
    }
    

}
