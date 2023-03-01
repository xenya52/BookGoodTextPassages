using System;
namespace BookGoodTextPassages;

public class Book
{

    //Attribute
    public string BookName { get; set; }
    Site[] sites { get; set; }
    public int siteCounter;

    //Methods
    //Creating sitecounter
    public Book(string name, int sitecount)
    {
        sites = new Site [sitecount];
        siteCounter = 0;
        this.BookName = name;
    }

    //Adding sites to the book
    public Site addSite(Site site)
    {
        sites[siteCounter] = site;
        siteCounter++;
        return site;
    }
}

