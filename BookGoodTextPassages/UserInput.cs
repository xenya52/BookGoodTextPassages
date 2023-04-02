using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
namespace BookGoodTextPassages;

public class UserInput
{
    /*BookInput*/
    public string UserInputBooks { get; set; } = String.Empty;
    /*QuoteInput*/
    public string UserInputQuotes { get; set; } = String.Empty;
}