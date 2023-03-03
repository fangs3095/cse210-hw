using System;

namespace Develop04
{
    public class BreathingActivity : Activity
    {

        public BreathingActivity(string name, string description) : base(name, description)
        {

        }


        private void breatheSequence(string message)
        {
            Console.Write($"{message}...");

            DisplayAnimation(4,1,3);

            Console.Write("Good! Now");

            DisplayAnimation(1,1,3);

            Console.Clear();
        }

        public void StartActivity()
        {

        DisplayStartingMessage();

        Console.WriteLine();

        SetDuration();

        Console.Clear();

        DateTime datetime = DateTime.Now;

        while(TimeLeft(datetime, _duration))
        {
            breatheSequence("Breathe In");
            
            breatheSequence("Breathe Out");
        }

        Console.Clear();

        DisplayEndingMessage();

        }
    }
}