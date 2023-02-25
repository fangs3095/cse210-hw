using System;
using System.Collections.Generic;
using System.Text;

namespace Develop04
{
    class ReflectionActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;

        public ReflectionActivity(List<string> prompts, List<string> questions, string name, string description, int duration) : base(name, description, duration)
        {
            _prompts = prompts;
            _questions = questions;
        }

        private void DisplayPrompt()
        {
            PromptGenerator promptGenerator = new PromptGenerator(_prompts);
            string prompt = promptGenerator.CreatePrompt();

            Console.WriteLine(prompt);
        }

        private void DisplayQuestion()
        {
            PromptGenerator promptGenerator = new PromptGenerator(_questions);
            string question = promptGenerator.CreatePrompt();

            Console.WriteLine(question);
        }

        public void StartActivity()
        {
            string [] sequence = new string[] { ".  ", ".. ", "..." };
            LoadingAnimation animation = new LoadingAnimation(sequence, 1);

            DisplayStartingMessage();

            Console.Clear();

            DateTime datetime = DateTime.Now;

            while(TimeLeft(datetime, GetDuration()))
            {
                DisplayPrompt();

                DateTime datetime2 = DateTime.Now;

                while(TimeLeft(datetime2, 13))
                {
                    animation.Turn();
                }

                Console.Clear();

                DisplayQuestion();

                DateTime datetime3 = DateTime.Now;

                while(TimeLeft(datetime3, 13))
                {
                    animation.Turn();
                }

                Console.Clear();
            }

            DisplayEndingMessage();

        }
    }
}
