using System;

namespace Develop04
{
    public class Activity {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(string name, string description, int duration)
        {
            _name = name;
            _description = description;
            _duration = duration;
        }

        public void Sleep(int sleepTime)
        {
            Thread.Sleep(sleepTime*1000);
        }

        public void DisplayStartingMessage()
        {
            string startingMessage = $"{_name} {_description}";
            Console.WriteLine(startingMessage);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
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

        public int GetDuration()
        {
            return _duration;
        } 
    }
}