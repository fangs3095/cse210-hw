using System;

class Program
{
    static void Main(string[] args)
    {
            bool menuLoop;
            do
            {
                Console.Clear();
                menuLoop = MainMenu();
                Console.Clear();
            }
            while (menuLoop);
        }

        static bool MainMenu()
        {
            Console.WriteLine("--- Welcome to your Word Memorizer ---\n");
            Console.WriteLine("What will you do today\n");
            

            Console.WriteLine("1- Create Entry");
            Console.WriteLine("2- Read Entries");

            string userChoice = Console.ReadLine();

            if (userChoice == "")
            {

            }

            else if (userChoice == "quit")
            {
                Console.WriteLine("");
            }

            return true;
        }
}