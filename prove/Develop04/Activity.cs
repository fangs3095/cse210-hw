using System;

namespace Develop04
{
    public class Activity {
        private string _name;
        private string _description;
        protected int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void SetDuration()
        {
            Console.WriteLine($"How long in seconds would you like the {_name} to last?");

            int duration = int.Parse(Console.ReadLine()); 

            _duration = duration;
        }


        public void Sleep(int sleepTime)
        {
            Thread.Sleep(sleepTime*1000);
        }

        public void DisplayStartingMessage()
        {
            Console.Write($"{_name}: {_description}");
            DisplayAnimation(3,1,5);
            Console.WriteLine();
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("Good Job!");

            Sleep(3);

            Console.WriteLine();

            Console.WriteLine($"You have completed {_duration} seconds of the {_name}");

            DisplayAnimation(3,1,5);
        }

        public bool TimeLeft(DateTime startTime, int duration)
        {
            DateTime futureTime = startTime.AddSeconds(duration);

            DateTime currentTime = DateTime.Now;
            if (currentTime < futureTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DisplayAnimation(int sequence, int delay, int duration)
        {
            DateTime datetime = DateTime.Now;
            LoadingAnimation animation = new LoadingAnimation(sequence, delay);

            while(TimeLeft(datetime, duration))
            {
                animation.Turn();
            }
        }

        public void DisplayPrompt(List<string> prompts)
        {
            PromptGenerator promptGenerator = new PromptGenerator(prompts);
            string question = promptGenerator.CreatePrompt();

            Console.WriteLine(question);
        }


    }
}