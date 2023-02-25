using System;
using System.Collections.Generic;
using System.Text;

namespace Develop04
{
    class ListingActivity : Activity
    {
        private List<string> _questions;
        private List<string> _answers = new List<string>();

        public ListingActivity(List<string> questions, string name, string description, int duration) : base(name, description, duration)
        {
            _questions = questions;
        }

        private void DisplayQuestion()
        {
            PromptGenerator promptGenerator = new PromptGenerator(_questions);
            string question = promptGenerator.CreatePrompt();

            Console.WriteLine(question);
        }

        public void StartActivity()
        {
            string [] sequence = new string[] { ".  ", ".. ", "..."};
            LoadingAnimation animation = new LoadingAnimation(sequence, 1);

            DisplayStartingMessage();

            Console.Clear();

            DateTime datetime = DateTime.Now;

            while(TimeLeft(datetime, GetDuration()))
            {
                DisplayQuestion();

                DateTime datetime2 = DateTime.Now;

                while(TimeLeft(datetime2, 13))
                {
                    animation.Turn();
                }

                Console.WriteLine("Its time for you to list");

                DateTime datetime3 = DateTime.Now;

                while(TimeLeft(datetime3, 15))
                {
                    string answer = Console.ReadLine();
                    Console.Clear();
                    _answers.Add(answer);
                    Console.WriteLine($"> {answer}");
                }

                Console.Clear();

                foreach (string answer in _answers)
                {
                    Console.WriteLine($"> {answer}");
                }

                Console.Write("This is your current list");

                DateTime datetime4 = DateTime.Now;

                while(TimeLeft(datetime4, 13))
                {
                    animation.Turn();
                }

                Console.Clear();

            }

            DisplayEndingMessage();

        }
    }
}
