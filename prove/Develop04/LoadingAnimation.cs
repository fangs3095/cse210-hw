using System;

namespace Develop04
{
    public class LoadingAnimation {
        private int _counter;
        private string[] _sequence;
        private int _delay;

        public LoadingAnimation()
        {
            _counter = -1;
            _sequence = new string[] { ".  ", ".. ", "..."};
            _delay = 1000;
        }

        public LoadingAnimation(int animation, int delay)
        {
            _counter = -1;
            _sequence = GetSequence(animation);
            _delay = delay*1000;
        }

        private string[] GetSequence(int animation)
        {
            string[] sequence;

            if (animation == 1)
            {
                sequence = new string[] { ".  ", ".. ", "..."};
            }
            else if (animation == 2)
            {
                sequence = new string[] { "/  ", "--", "\\  ", "--"};
            }
            else if (animation == 3)
            {
                sequence = new string[] { "-", "+", "o", "O"};
            }
            else
            {
                sequence = new string[] {"3", "2", "1"};
            }

            return sequence; 
        }

        public void Turn()
        {
            _counter++;

            if (_counter >= _sequence.Length)
            {
                _counter = 0;
            }

            Console.Write(_sequence[_counter]);

            Console.SetCursorPosition(Console.CursorLeft - _sequence[_counter].Length, Console.CursorTop);

            Thread.Sleep(_delay);

        }
    }
}