using System;
using Develop04;

class Program
{
    static void Main(string[] args)
    {
        List<string> ReflectionQuestions = GetList("ReflectionQuestions.csv");
        List<string> ReflectionsPrompts = GetList("ReflectionPrompts.csv");
        List<string> ListingQuestions = GetList("ReflectionPrompts.csv");

        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflectionActivity = new ReflectionActivity(ReflectionsPrompts, ReflectionQuestions, "Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity listingActivity = new ListingActivity(ListingQuestions, "Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        
        bool menuLoop;
        do
        {
            Console.Clear();
            menuLoop = MainMenu(breathingActivity,reflectionActivity,listingActivity);
            Console.Clear();
        }
        while (menuLoop);

    }

    static bool MainMenu(BreathingActivity breathingActivity, ReflectionActivity reflectionActivity, ListingActivity listingActivity)
    {
        Console.WriteLine("--- Welcome to your Mindfulness program ---\n");
        Console.WriteLine("What will you do today?\n");
        Console.WriteLine("1- Breathing Activity\n\n2- Reflection Activity\n\n3-Listing Activity\n\n4- quit\n");

        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Console.Clear();
            breathingActivity.StartActivity();
        }

        else if (userChoice == "2")
        {
            Console.Clear();
            reflectionActivity.StartActivity();
        }

        else if (userChoice == "3")
        {
            Console.Clear();
            listingActivity.StartActivity();
        }

        else if (userChoice == "4")
        {
            Console.Clear();
            Console.WriteLine("Goodbye!");
            Thread.Sleep(3000);
            return false;
        }

        return true;
    }

    static List<string> GetList(string filePath)
    {

        using(var reader = new StreamReader(filePath))
        {
            List<string> list = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                list.Add(line);
            }

        return list;

        }
    }


}