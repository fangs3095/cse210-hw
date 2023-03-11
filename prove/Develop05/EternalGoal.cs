using System;
using System.Collections.Generic;
using System.Text;

namespace Develop05
{
    class EternalGoal : Goal
    {

        public EternalGoal(string name, string description, int value) : base(name, description, value)
        {

        }

        public override string GetStringRepresentation()
        {
            string StringRepresentation = $"EternalGoal:{_name}~{_description}~{_value}";
            return StringRepresentation;
        }

        public override void MarkComplete()
        {
            // nothing
        }

        public override void DisplayEntry()
        {
            Console.Write($"[ ] {_name}= {_description}");
        }

    }
}