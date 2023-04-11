namespace BookGoodTextPassages;

public class CBookCollection
{
    /*Lists*/
    public Dictionary<string, CBook> BookList { get; set; } = new ();
    /*Methods*/
    public void createBook(string name)
    {
        BookList.Add(name, new CBook());
    }

    public void addQouteToBook(string name, string qoute)
    {
        CBook book;
        BookList.TryGetValue(name, book);
    }
}