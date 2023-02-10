using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class WordPicker
    {
        public WordPicker()
        {
        }

        public string PickWords(Scripture scripture)
        {
            List<Verse> verses = scripture.GetVerses();
            Random rndVerse = new Random();
            int versIndex = rndVerse.Next(0,verses.Count());

            List<string> words = verses[versIndex].getWords();
            Random rndWord = new Random();
            int wordIndex = rndWord.Next(0,words.Count());

            return words[wordIndex];
        }
    }
}