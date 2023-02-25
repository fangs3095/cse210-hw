using System;

namespace Develop04
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {

        }

        public void StartActivity()
        {
        string [] sequence1 = new string[] { ".", "..", "..." };
        string [] sequence2 = new string[] { "6", "5", "4", "3", "2", "1"};

        LoadingAnimation animation = new LoadingAnimation(sequence2, 1);
        LoadingAnimation animation2 = new LoadingAnimation(sequence1, 1);

        DisplayStartingMessage();
        
        Sleep(5);

        Console.Clear();

        DateTime datetime = DateTime.Now;

        while(TimeLeft(datetime, GetDuration()))
        {
            Console.Write("Breathe Please");

            DateTime datetime2 = DateTime.Now;

            while(TimeLeft(datetime2, 6))
            {
                animation.Turn();
            }

            Console.Clear();

            Console.Write("Good Job! Now ");

            DateTime datetime3 = DateTime.Now;

            while(TimeLeft(datetime3, 3))
            {
                animation2.Turn();
            }

            Console.Clear();
        }

        Console.Clear();

        DisplayEndingMessage();

        Sleep(5);

        }
    }
}