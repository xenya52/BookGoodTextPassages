using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
namespace BookGoodTextPassages;

public class BooksQuotesSave : UserInput
{
    /*BooksSave*/
    public List<string> Books = new List<string>();

    public void SaveBook()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Write you quote here: ");
        UserInputBooks = Convert.ToString(Console.ReadLine());
        Books.Add(UserInputBooks);
    }

    public List<string> Quotes = new List<string>();

    public void SaveQuote()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Write you quote here: ");
        UserInputQuotes = Convert.ToString(Console.ReadLine());
        Quotes.Add(UserInputQuotes);
    }
}