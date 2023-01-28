using System;
using System.Collections.Generic;

class PromptGenerator
{
    
    int randomNumber;

    public List<string> promptList = new List<string>();
    public Random random = new Random();

    public PromptGenerator()
    {
        promptList.Add("What did you do at school and or wrok today?");
        promptList.Add("Share a intresting event that happen today.");
        promptList.Add("What movie did you watch today?");
        promptList.Add("Did a intresting thought that got you think come to you today/");
        promptList.Add("Who did you meet today?");

    }
    public string getPrompt()
    {
        randomNumber = random.Next(0, 4);
        return promptList[randomNumber];
    }
}
