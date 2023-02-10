using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Verse
    {
        private string _number;
        private List<string> _words = new List<string>();

        public Verse()
        {
            _number = "1";
            _words.Add("This");
            _words.Add("is");
            _words.Add("a");
            _words.Add("verse");
        }
        public Verse(string number, List<string> words)
        {
            _number = number;
            foreach (string word in words)
            {
                _words.Add(word);
            }
        }

        public List<string> getWords()
        {
            return _words;
        }

        public void DisplayVerse()
        {
            string verse = string.Join( " ", _words);
            Console.WriteLine($"{_number}: {verse}");
        }
    }
}