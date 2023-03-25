using System;
using System.Collections.Generic;


class Entryies
{
    public string userInput;
    public string prompt;
    public string date;
    public List<string> entryList = new List<string>();
    QandA qandA = new QandA();
    FileHandling fileHandling = new FileHandling();

    public void addEntry()
    {
    
    Console.WriteLine("Enter the curent date");
    date = Console.ReadLine();
    entryList.Add(date);
    prompt = qandA.getPrompt();
    Console.WriteLine(prompt);
    entryList.Add(prompt);
    userInput = Console.ReadLine();
    entryList.Add(userInput);
    }

    public void display()
    {
        for (int i = 0; i < entryList.Count; i += 3) 
        {
            Console.WriteLine("Date: " + entryList[i]);
            Console.WriteLine("Journal Prompt" + entryList[i + 1]);
            Console.WriteLine("Your writing: " + entryList[i + 2]);
        }
    }

}