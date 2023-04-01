using System;
using System.Collections.Generic;

class QoteGenerators
{
    
    int randomNumber;

    public List<string> qoutelist = new List<string>();
    public Random random = new Random();

    public QoteGenerators()
    {
        qoutelist.Add("“No! Try not. Do. Or do not. There is no try.”  - Yoda");
        qoutelist.Add("“It does not do to dwell on dreams and forget to live.”― J.K. Rowling, Harry Potter and the Sorcerer's Stone");
        qoutelist.Add("Never put off until tomorrow what can be done today. - Master Wu");
        qoutelist.Add("Those whose memories fade seek to carve them in their hearts");
        qoutelist.Add("You said you have a dream… That dream… Make it come true! Make your wonderful dream a reality, and it will become your truth! <Player>! If anyone can, it's you! Well, then… Farewell! - N");

    }
    public string getScrip()
    {
        randomNumber = random.Next(0, 4);
        return qoutelist[randomNumber];
    }
}