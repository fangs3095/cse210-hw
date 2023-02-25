using System;

namespace Develop04
{
    public class LoadingAnimation {
        private int _counter;
        private string[] _sequence;
        private int _delay;

        public LoadingAnimation(string[] sequence, int delay)
        {
            _counter = -1;
            _sequence = sequence;
            _delay = delay*1000;

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