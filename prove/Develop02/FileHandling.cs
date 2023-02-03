using System;

class FileHandling
{
    string fileName = "journal.text";
    public void load()
    {
        using  (StreamReader reader = new StreamReader(fileName))
        {
            string line = reader.ReadLine();
            while(line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }

    public void Save (string date, string prompt, string userInput)
    {
        using (StreamWriter file = new StreamWriter(fileName, true))
        {
            file.WriteLine($"{date}\n");
            file.WriteLine($"{prompt}\n");
            file.WriteLine($"{userInput}\n");
        }
    }
        
}    
