using System;
using System.Collections.Generic;
using System.Text;

namespace Develop04
{
    class ListingActivity : Activity
    {
        private List<string> _questions;
        private List<string> _answers = new List<string>();

        public ListingActivity(List<string> questions, string name, string description) : base(name, description)
        {
            _questions = questions;
        }

        private void StartListing(int duration)
        {
                DateTime datetime = DateTime.Now;

                while(TimeLeft(datetime, duration))
                {
                    Console.Write(">");
                    string answer = Console.ReadLine();
                    _answers.Add(answer);
                }           
        }

        private void DisplayList()
        {
                foreach (string answer in _answers)
                {
                    Console.WriteLine($"> {answer}");
                }
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
                Console.WriteLine("+ _ - * - Carefully read the following question, press enter once you feel prepared - * - _ +");

                Console.WriteLine();

                DisplayPrompt(_questions);

                Console.WriteLine();

                Console.ReadLine();

                Console.Clear();

                Console.Write("Ok! time for you to list in...");

                DisplayAnimation(4,1,3);

                Console.WriteLine();

                StartListing(10);

                Console.Clear();

                Console.WriteLine("This is your current list");

                Console.WriteLine();

                DisplayList();

                Console.WriteLine();

                DisplayAnimation(3,3,5);

                Console.Clear();
            }

            Console.WriteLine();

            DisplayEndingMessage();


        }
    }
}
