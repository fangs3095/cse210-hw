using System;

class FileHandling
{

        string fileName = "journal.text";
    
   



    public void load()
    
        {
            string [] Lines = System.IO.File.ReadAllLines("joural.text");
        
            foreach (string line  in Lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string userInput = parts[2];
                Console.WriteLine(line);
            }
        }

    public void save (string date, string prompt, string userInput);

        {
            Console.Write("Enter the Filename: ");
            fileName = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(fileName, true))
            {
                file.WriteLine($"{date}\n");
                file.WriteLine($"{prompt}\n");
                file.WriteLine($"{userInput}\n");
            }
        }
           
        
}    
