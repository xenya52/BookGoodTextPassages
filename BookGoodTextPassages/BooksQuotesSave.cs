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