using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
namespace BookGoodTextPassages;

public class BooksQuotesSave : UserInput
{
    /*BooksSave*/
    public List<string> Books { get; set; } = new List<string>();

    public void SaveANewBook()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Write you new Book here: ");
        UserInputBooks = Convert.ToString(Console.ReadLine());
        Books.Add(UserInputBooks);
    }

    public List<string> Quotes = new List<string>();

    public void SaveANewQuote()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Write you quote here: ");
        UserInputQuotes = Convert.ToString(Console.ReadLine());
        Quotes.Add(UserInputQuotes);
    }
}