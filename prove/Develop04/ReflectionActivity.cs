using System;
using System.Collections.Generic;
using System.Text;

namespace Develop04
{
    class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectionActivity(List<string> prompts, List<string> questions, string name, string description) : base(name, description)
        {
            _prompts = prompts;
            _questions = questions;
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
                Console.WriteLine("+ _ - * - Carefully read the following prompt, press enter to continue - * - _ +");

                Console.WriteLine();

                DisplayPrompt(_prompts);

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

                for (int i = 0; i < 5; i++)
                {
                    DisplayPrompt(_questions);

                    DisplayAnimation(2,1,15);

                }

                Console.Clear();

            }

            DisplayEndingMessage();

        }
    }
}
