using System;
using System.Collections.Generic;
using System.Text;

namespace Develop05
{
    class Goal
    {
        protected string _name;
        protected string _description;
        protected int _value;
        protected bool _complete;

        public Goal(string name, string description, int value, bool complete = false)
        {
            _name = name;
            _description = description;
            _value = value;
            _complete = complete;
        }

        public virtual string GetStringRepresentation()
        {
            string StringRepresentation = $"Goal:{_name}~{_description}~{_value}~{_complete}";
            return StringRepresentation;
        }

        public virtual void MarkComplete()
        {
            _complete = true;
        }

        public virtual int getPoints()
        {
            return _value;
        }

        public virtual void DisplayEntry()
        {
            if(_complete)
            {
                Console.Write($"[x] {_name}= {_description}");
            }
            else
            {
                Console.Write($"[ ] {_name}= {_description}");
            }
        }
    }
}
