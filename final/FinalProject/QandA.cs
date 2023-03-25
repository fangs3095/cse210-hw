using System;
using System.Collections.Generic;

class QandA
{
    
    int randomNumber;

    public List<string> promptList = new List<string>();
    public Random random = new Random();

    public QandA()
    {
        promptList.Add("What was your favorite show as a kid?");
        promptList.Add("Do you think that shows talk down to kids these days?");
        promptList.Add("Do you think that Skylanders ruined Spyro yes, or no and then explain?");
        promptList.Add("What is your favorite lego theme?");
        promptList.Add("What is your favorite Animal?");

    }
    public string getPrompt()
    {
        randomNumber = random.Next(0, 4);
        return promptList[randomNumber];
    }
}