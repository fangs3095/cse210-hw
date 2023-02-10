using System;
using Classes;

class Program
{
    static void Main(string[] args)
    {
            string filePath = @"C:\Users\dicma\OneDrive\Documents\byui\cse210\cse210-hw\prove\Develop03\ScriptureList.csv";
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string separator = ",";
            string line;
            file.ReadLine();
            line = file.ReadLine();
            /*List<Scripture> scriptures = new List<Scripture>();*/

            string[] row = line.Split(separator);
            string name = row[0];
            string chapter = (row[1]);
            string verseStart = (row[2]);
            string verseEnd = (row[3]);
            string filename = (row[4]);
            Console.WriteLine(filename);

            System.IO.StreamReader verseFile = new System.IO.StreamReader(filename);
            List<string> verses = System.IO.File.ReadAllLines(filename).ToList<string>();
            foreach (string verse in verses)
            {
                Console.WriteLine(verse);
            }
            
            Scripture scripture = new Scripture(name, chapter, verseStart, verseEnd, verses);

            Memorizer memorizer = new Memorizer(scripture);
            bool menuLoop;
            do
            {
                Console.Clear();
                menuLoop = MainMenu(scripture,memorizer);
                Console.Clear();
            }
            while (menuLoop);
        }

        static bool MainMenu(Scripture scripture, Memorizer memorizer)
        {
            Console.WriteLine("--- Welcome to your Word Memorizer ---\n");
            Console.WriteLine("Today you will memorize\n");
            Console.WriteLine();
            scripture.DisplayScripture();
            Console.WriteLine();

            Console.WriteLine("Press Enter to hide words");
            Console.WriteLine("Enter quit to exit the program"); 

            string userChoice = Console.ReadLine();

            if (userChoice == "")
            {
                memorizer.HideWords(10);
            }

            else if (userChoice == "quit")
            {
                Console.WriteLine("GoodBye");
                Console.ReadLine();
                return false;
            }

            return true;
        }

        static Scripture GetScripture(string filePath)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string separator = ",";
            string line;
            line = file.ReadLine();
            /*List<Scripture> scriptures = new List<Scripture>();*/

            string[] row = line.Split(separator);
            string name = row[0];
            string chapter = (row[1]);
            string verseStart = (row[2]);
            string verseEnd = (row[3]);
            string filename = (row[4]);

            System.IO.StreamReader verseFile = new System.IO.StreamReader(filename);
            List<string> verses = System.IO.File.ReadAllLines(filename).ToList<string>();

            Scripture scripture = new Scripture(name, chapter, verseStart, verseEnd, verses);

            return scripture;
        }
}