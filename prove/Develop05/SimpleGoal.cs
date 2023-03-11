using System;
using System.Collections.Generic;
using System.Text;

namespace Develop05
{
    class SimpleGoal : Goal
    {

        public SimpleGoal(string name, string description, int value, bool complete = false) : base(name, description, value, complete)
        {

        }

        public override string GetStringRepresentation()
        {
            string StringRepresentation = $"SimpleGoal:{_name}~{_description}~{_value}~{_complete}";
            return StringRepresentation;
        }

    }
}