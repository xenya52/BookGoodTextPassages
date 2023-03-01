using System;
namespace BookGoodTextPassages;

public class Site
{

    public string [] qoutes { get; set; }
    public int qoutecounter { get; set; }

    public Site(int qouteCount)
	{
        qoutes = new string[qouteCount];
        qoutecounter = 0;
	}

    public Site addqoute(string qoute)
    {
        qoutes[qoutecounter] = qoute;
        qoutecounter++;
        return this;
    }
 
}

