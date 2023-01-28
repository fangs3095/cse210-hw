using System;
using System.Collections.Generic;

class ScripturesGenerator
{
    
    int randomNumber;

    public List<string> scriptureList = new List<string>();
    public Random random = new Random();

    public ScripturesGenerator()
    {
        scriptureList.Add("Helaman 3,3: 3 And it came to pass in the forty and sixth, yea, there was much contention and many dissensions; in the which there were an exceedingly great many who departed out of the land of Zarahemla, and went forth unto the land anorthward to inherit the land.");
        scriptureList.Add("1 Nephi 1, 1 I, Nephi, having been aborn of bgoodly cparents, therefore I was dtaught somewhat in all the learning of my father; and having seen many eafflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a frecord of my proceedings in my days.");
        scriptureList.Add("Moroni 10, 34 And now I bid unto all, farewell. I soon go to arest in the bparadise of God, until my cspirit and body shall again dreunite, and I am brought forth triumphant through the eair, to meet you before the fpleasing bar of the great gJehovah, the Eternal hJudge of both quick and dead. Amen.");
        scriptureList.Add("Matthew 2,9 When they had heard the king, they departed; and, lo, the star, which they saw in the east, went before them, till it came and stood over where the young child was. 10 When they saw the star, they rejoiced with exceeding great joy. 11 ¶ And when they were come into the house, they saw the young child with Mary his mother, and fell down, and worshipped him: and when they had opened their treasures, they presented unto him gifts; gold, and afrankincense, and myrrh.");
        

    }
    public string getScrip()
    {
        randomNumber = random.Next(0, 3);
        return scriptureList[randomNumber];
    }
}