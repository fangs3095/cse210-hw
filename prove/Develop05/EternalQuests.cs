using System;
using System.Collections.Generic;
using System.Text;

namespace Develop05
{
    class EternalQuests
    {
        private List<Goal> _goals = new List<Goal>();
        private int _points = 0;

        public EternalQuests()
        {
        }

        public int getPoints()
        {
            return _points;
        }

        public int GetListLength()
        {
            return _goals.Count();
        }
        public void RecordEvent(int GoalIndex)
        {
            _goals[GoalIndex].MarkComplete();
            _points += _goals[GoalIndex].getPoints();
        }

        public void Remove(int GoalIndex)
        {
            _goals.Remove(_goals[GoalIndex]);
        }

        public void displayGoals()
        {
            int counter = 1;
            foreach (Goal goal in _goals)
            {
                Console.Write($"{counter} - ");
                counter++;
                goal.DisplayEntry();
                Console.WriteLine();
            }
        }

        public void addToGoals(Goal goal)
        {
            _goals.Add(goal);
        }

        public void SaveGoals(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_points);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }

        }
        public void LoadGoals(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            List<string> goalStrings = new();
            goalStrings.AddRange(lines);

            _points = Int32.Parse(goalStrings[0]);
            goalStrings.RemoveAt(0);

            _goals.Clear();

            foreach (string line in goalStrings)
            {
                string[] splitLine = line.Split(":");

                string GoalType = splitLine[0];
                string[] GoalConten = splitLine[1].Split("~");

                if(GoalType == "SimpleGoal")
                {
                    string name = GoalConten[0];
                    string description = GoalConten[1];
                    int value = Int32.Parse(GoalConten[2]);
                    bool complete = bool.Parse(GoalConten[3]);

                    addToGoals( new SimpleGoal(name, description, value, complete));
                }
                else if(GoalType == "EternalGoal")
                {
                    string name = GoalConten[0];
                    string description = GoalConten[1];
                    int value = Int32.Parse(GoalConten[2]);

                    addToGoals( new EternalGoal(name, description, value));
                }
                else
                {
                    string name = GoalConten[0];
                    string description = GoalConten[1];
                    int value = Int32.Parse(GoalConten[2]);
                    int bonus = Int32.Parse(GoalConten[3]);
                    int checkRequired = Int32.Parse(GoalConten[4]);
                    int check = Int32.Parse(GoalConten[5]);

                    addToGoals( new ChecklistGoal(name, description, value, bonus, checkRequired, check));
                }
            }
        }
    }
}
