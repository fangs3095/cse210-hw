using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Memorizer
    {
        private Scripture _scripture;
        private int _wordsHidden;

        public Memorizer()
        {
            _scripture = new Scripture();
        }

        public Memorizer(Scripture scripture)
        {
            _scripture = scripture;
        }

        private void WordsLeft()
        {
            List<Verse> verses = _scripture.GetVerses();

            foreach (Verse verse in verses)
            {
                List<string> words = verse.getWords();

                for (int i = 0; i < words.Count(); i++)
                {
                    if (words[i].Contains("_"))
                    {
                        _wordsHidden += 1;
                    }
                }
            }
        }

        public void HideWords(int numberWords)
        {
            WordPicker wordPicker = new WordPicker();
            int counter = 0;
            while (counter < numberWords)
            {
                string wordToHide = wordPicker.PickWords(_scripture);

                List<Verse> verses = _scripture.GetVerses();

                foreach (Verse verse in verses)
                {
                    List<string> words = verse.getWords();

                    for (int i = 0; i < words.Count(); i++)
                    {
                        if (words[i] == wordToHide)
                        {
                            words[i] = new string('_', words[i].Length);
                            counter += 1;
                        }
                    }
                }
            }
        }

        public bool CanHide()
        {
            List<Verse> verses = _scripture.GetVerses();
            int totalWords = 0;

            foreach (Verse verse in verses)
            {
                List<string> words = verse.getWords();

                totalWords += words.Count();
            }

            if (totalWords == _wordsHidden)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}