using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookGoodTextPassages;
internal class BooksAndQuotesInput
{
    //Attributes
    public string BookInput { get; set; } = string.Empty;
    public List<string> Book = new List<string>();
    public string QuoteInput { get; set; } = string.Empty;
    public List<string> Quotes = new List<string>();
    public void BookInputMethod()
    {
        Console.Clear();
        Console.WriteLine("Pls write the name of the Book");
        BookInput = Convert.ToString(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("You book name is " + BookInput);

    }
    public void QuoteInputMethod()
    {
        Console.Clear();
        Console.WriteLine("Pls write the name of the Quote");
        QuoteInput = Convert.ToString(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("You Quote is");
        Console.WriteLine("''"+QuoteInput+"''");
    }
}
