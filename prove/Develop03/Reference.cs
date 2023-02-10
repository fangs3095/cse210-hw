   using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Reference
    {
        private string _name;
        private string _chapter;
        private string _verseStart;
        private string _verseEnd;

        public Reference()
        {
            _name = "name";
            _chapter = "0";
            _verseStart = "1";
            _verseEnd = "0";
        }

        public Reference(string name,string chapter, string verseStart)
        {
            _name = name;
            _chapter = chapter;
            _verseStart = verseStart;
            _verseEnd = "0";
        }

        public Reference(string name,string chapter,string verseStart, string verseEnd)
        {
            _name = name;
            _chapter = chapter;
            _verseStart = verseStart;
            _verseEnd = verseEnd;
        }

        public void DisplayReference()
        {
            if (_verseEnd == "0")
            {
                Console.WriteLine($"{_name} {_chapter}: {_verseStart}:");
            }
            else
            {
                Console.WriteLine($"{_name} {_chapter}: {_verseStart}-{_verseEnd}:");
            }
            
        }
    }
}
    