using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Scripture
    {
        private Reference _reference;
        private List<Verse> _verses = new List<Verse>();

        public Scripture()
        {
            Reference reference = new Reference();
            _reference = reference;

            Verse verse = new Verse();
            _verses.Add(verse);
        }

        public Scripture(string name, string chapter, string verseStart, List<string> verses)
        {
            Reference reference = new Reference(name,chapter,verseStart);
            _reference = reference;

            foreach (string line in verses)
            {
                List<string> words = line.Split(" ").ToList<string>();
                Verse verse = new Verse(words[0],words);
                _verses.Add(verse);
            }
        }

        public Scripture(string name, string chapter, string verseStart,string verseEnd, List<string> verses)
        {
            Reference reference = new Reference(name,chapter,verseStart,verseEnd);
            _reference = reference;

            foreach (string line in verses)
            {
                List<string> words = line.Split(" ").ToList<string>();
                string number = words[0];
                words.RemoveAt(0);
                Verse verse = new Verse(number,words);
                _verses.Add(verse);
            }
        }

        public List<Verse> GetVerses()
        {
            return _verses;
        }


        public void DisplayScripture()
        {
            _reference.DisplayReference();
            foreach (Verse verse in _verses)
            {
                verse.DisplayVerse();
            }

        }
    }
}