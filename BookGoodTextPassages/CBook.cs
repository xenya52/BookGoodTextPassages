namespace BookGoodTextPassages;

public class CBook
{ 
    string UserQuoteInput = String.Empty;
    List<string> QuotesList { get; set; } = new List<string>();
    string description { get; set; } = String.Empty;

    /*Konstruktor = Methode*/
    public CBook()
    {
        /*noop*/
    } 
    /*Methode*/
    public void QuoteInputToListMethod()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Now you can create a new book,");
        Console.WriteLine("please type in the name of the book");
        UserQuoteInput = Convert.ToString(Console.ReadLine());
        QuotesList.Add(UserQuoteInput);
    }
}