using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
            EternalQuests eternalQuests = new EternalQuests();
            bool menuLoop;
            do
            {
                Console.Clear();
                menuLoop = MainMenu(eternalQuests);
                Console.Clear();
            }
            while (menuLoop);
        }

        static bool MainMenu(EternalQuests eternalQuest)
        {
            //Create a menu for the user to iteract with
            Console.WriteLine($"Points = {eternalQuest.getPoints()}\n");

            Console.WriteLine("--- Welcome to your Eternal Quest, what will you do today\n");

            Console.WriteLine("1- Create Goal");
            Console.WriteLine("2- List Goals");
            Console.WriteLine("3- Save Goals");
            Console.WriteLine("4- Load Goal");
            Console.WriteLine("5- Record Event");
            Console.WriteLine("6- Remove Goal");
            Console.WriteLine("7- Quit");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Clear();

                Console.WriteLine("What type of Goal do you want to create?");
                Console.WriteLine();

                Console.WriteLine("1- Simple Goal");
                Console.WriteLine("2- Eternal Goal");
                Console.WriteLine("3- Checklist Goal");

                string answer = Console.ReadLine();

                if(answer == "1")
                {
                    Console.Clear();

                    Console.WriteLine("What is the name of this Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Whas it the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points will this goal give?");
                    int value = Int32.Parse(Console.ReadLine());

                    eternalQuest.addToGoals(new SimpleGoal(name,description,value));

                   Message("Goal Added Sucessfully");
                }
                else if(answer == "2")
                {
                    Console.Clear();

                    Console.WriteLine("What is the name of this Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Whas it the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many points will this goal give?");
                    int value = Int32.Parse(Console.ReadLine());

                    eternalQuest.addToGoals(new EternalGoal(name, description, value));

                    Message("Goal Added Sucessfully");
                }
                else if(answer == "3")
                {
                    Console.Clear();

                    Console.WriteLine("What is the name of this Goal?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Whas it the description of this Goal?");
                    string description = Console.ReadLine();
                    Console.WriteLine("How many times will you have to complete this goal?");
                    int checkRequired = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("How many points will this goal give?");
                    int value = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("How many bonus points will this goal give once complete?");
                    int bonus = Int32.Parse(Console.ReadLine());

                    eternalQuest.addToGoals(new ChecklistGoal(name, description, value, bonus, checkRequired));

                    Message("Goal Added Sucessfully");
                }
                else
                {
                    Message("Please choose a valid answer");
                }

            }

            else if (userChoice == "2")
            {
                Console.Clear();

                Console.WriteLine("These are your Goals:");
                eternalQuest.displayGoals();

                if(eternalQuest.GetListLength() == 0)
                {
                    Console.WriteLine("nothing to see here...");
                }

                Console.ReadLine();
            }

            else if (userChoice == "3")
            {
                Console.Clear();

                Console.WriteLine("Please type the name of the file where the goals will be saved");

                string filename = Console.ReadLine();

                eternalQuest.SaveGoals(filename);

                Message("File Saved Sucessfully");
            }

            else if (userChoice == "4")
            {
                Console.Clear();

                Console.WriteLine("Please type the name of the file where the goals were saved");

                string filename = Console.ReadLine();

                ConfirmFileLoad(filename, eternalQuest);
            }

            else if (userChoice == "5")
            {
                if(eternalQuest.GetListLength() != 0)
                {
                    Console.Clear();

                    Console.WriteLine("These are your Goals:");
                    eternalQuest.displayGoals();
                    Console.WriteLine();

                    Console.WriteLine("What goal would you like to mark as complete?");

                    int goalChosen = Int32.Parse(Console.ReadLine());
                    goalChosen -= 1;
                    int length = eternalQuest.GetListLength();

                    if(goalChosen < length)
                    {
                        eternalQuest.RecordEvent(goalChosen);
                        Message("Good job! the event was recorded sucessfully");
                    }
                    else
                    {
                        Message("This goal doesn't exists yet");
                    }
                }

                else{Message("There are no goals, add some goals first to beging your list");}
            }

            else if (userChoice == "6")
            {
                if(eternalQuest.GetListLength() != 0)
                {
                    Console.Clear();

                    Console.WriteLine("These are your Goals:");
                    eternalQuest.displayGoals();
                    Console.WriteLine();

                    Console.WriteLine("What goal would you like to remove for your list?");

                    int goalChosen = Int32.Parse(Console.ReadLine());
                    goalChosen -= 1;
                    int length = eternalQuest.GetListLength();

                    if(goalChosen < length)
                    {
                        eternalQuest.Remove(goalChosen);
                        Message("The goal has been deleted sucessfully");
                    }
                    else
                    {
                        Message("This goal doesn't exists");
                    }
                }

                else{Message("There are no goals, add some goals first");}

            }

            else
            {
                Message("Have a good time. See you next time");
                return false;
            }

            return true;
    }

        static  void ConfirmFileLoad(string filename, EternalQuests eternalQuest)
        {
            Console.Clear();

            if (File.Exists(filename))
            {
                eternalQuest.LoadGoals(filename);
                Message("File Loaded Sucessfully");
                
            }

            else{
                Message("No such file in directory");
            }
        }

        static  void Message(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadLine();
        }
}
