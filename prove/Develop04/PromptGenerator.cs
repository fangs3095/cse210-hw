using System;
using System.Collections.Generic;
using System.Text;

namespace Develop04
{
    class PromptGenerator
    {
        private List<string> _list;
        public PromptGenerator(List<string> list)
        {
            _list = list;
        }

        public string CreatePrompt()
        {
            Random random = new Random();

            var randomIndex = random.Next(0, _list.Count);
            string prompt = _list[randomIndex];

            return prompt;   
        }
    }
}
