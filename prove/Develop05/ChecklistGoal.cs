using System;
using System.Collections.Generic;
using System.Text;

namespace Develop05
{
    class ChecklistGoal : Goal
    {
        private int _checkRequired;
        private int _check;
        private int _bonus;

        public ChecklistGoal(string name, string description, int value, int bonus,int checkRequired, int check = 0) : base(name, description, value)
        {
            _check = check;
            _checkRequired = checkRequired;
            _bonus = bonus;
        }

        public override void MarkComplete()
        {
            if (_check != _checkRequired)
            {
                _check++;
            }
        }

        public override int getPoints()
        {
            int new_value = 0;

            if (_check == _checkRequired)
            {
                new_value = _value + _bonus;
            }
            else
            {
                new_value = _value;
            }

            return new_value;
        }

        public override void DisplayEntry()
        {
            if (_check == _checkRequired)
            {
                Console.Write($"[x] {_name}= {_description} -- currently completed: {_check}/{_checkRequired}");
            }
            else
            {
                Console.Write($"[ ] {_name}= {_description} -- currently completed: {_check}/{_checkRequired}");
            }
        }

        public override string GetStringRepresentation()
        {
            string StringRepresentation = $"ChecklistGoal:{_name}~{_description}~{_value}~{_bonus}~{_checkRequired}~{_check}";
            return StringRepresentation;
        }

    }
}