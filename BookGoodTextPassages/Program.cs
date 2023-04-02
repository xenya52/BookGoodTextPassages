using System.Text.Json;//You need to add this
using System.IO; //You need to add this too
using System.Security.Cryptography.X509Certificates;
namespace BookGoodTextPassages;
using System.Text.Json;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        /*Introduction*/
        Console.WriteLine("Welcome to my program!");
        Thread.Sleep(0);
        Console.WriteLine("I will show you all the Book passages that touched me deeply");
        Thread.Sleep(0);
        Console.WriteLine("And you can write some too...");
        Thread.Sleep(0);
        Console.Clear();

        bool CheckPoint1 = true;
        do //Reset point
        {
            /*Object for my written Books and Quotes*/
            BooksQuotesSave booksQuotesSave = new();
            /*MainMenu*/
            PatternMenu MainMenu = new();
            MainMenu.PatternHeadLineMethod("Main Menu");
            MainMenu.PatternTextMethod("Wanna write something", 1);
            MainMenu.PatternTextMethod("Wanna read something", 2);
            MainMenu.PatternTextMethod("Wanna quit the software", 3);
            int InputMain = 0;
            InputMain = Convert.ToInt32(Console.ReadLine());

            if (InputMain == 1)
            {
                /*WritingMenu*/
                PatternMenu WritingMenu = new();
                WritingMenu.PatternHeadLineMethod("Writing Menu");
                WritingMenu.PatternTextMethod("Creating a new book", 1);
                WritingMenu.PatternTextMethod("Creating a new quote", 2);
                WritingMenu.PatternTextMethod("Back to Main Menu", 3);
                InputMain = Convert.ToInt32(Console.ReadLine());
                bool BookThere = false;
                if (InputMain == 1)
                {
                    booksQuotesSave.SaveANewBook();
                    JsonToFile(booksQuotesSave.Books, "SaveBookAndQuote");
                }
                else if (InputMain == 2 && BookThere == true)
                {
                    booksQuotesSave.SaveANewQuote();
                    JsonToFile(booksQuotesSave.Quotes, "SaveBookAndQuote");
                }
                else if (InputMain == 2 && BookThere == false)
                {
                    Console.WriteLine("Error: No book too put it inside");
                    Thread.Sleep(5000);
                }
                else if (InputMain == 3)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Error: No valid number");
                    Thread.Sleep(5000);
                }
            }


            else if (InputMain == 2)
            {
                PatternMenu ReadingMenu = new();
                ReadingMenu.PatternHeadLineMethod("Reading Menu");
                ReadingMenu.PatternTextMethod("Choose the book", 1);
                ReadingMenu.PatternTextMethod("Go to Main Menu",2);
                InputMain = Convert.ToInt32(Console.ReadLine());
                if (InputMain == 1)
                {
                    /*ToReadAJsonData*/
                    static BooksQuotesSave ConfigReader (string path)
                    {
                        string json = File.ReadAllText(path);
                        return JsonSerializer.Deserialize<BooksQuotesSave>(json);
                    }
                    /*OutputFromReadingJsonData*/
                    BooksQuotesSave booksQuotesFromJsonFile = ConfigReader("SaveBookAndQuote");
                    /*Choose the book*/
                    Console.ReadLine(booksQuotesFromJsonFile.Books);
                    Console.ReadKey();
                }
                else if (InputMain == 666)
                {
                    return;
                }
            }


            else if (InputMain == 3)
            {
                CheckPoint1 = false;
            }


            else 
            {
                Console.WriteLine("Error: No valid number");
                Thread.Sleep(5000);
            }
        } while (CheckPoint1 == true);





        /*
        if (Input1 == 1)
        {
            //Creation menu
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=============");
            Console.WriteLine("Creation menu");
            Console.WriteLine("=============");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|| Create a new Book");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|| Press [ 1 ]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|| Create a new Text passage");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|| Press [ 2 ]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|| Go back");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("|| Press [ 3 ]");
            int Input2 = Convert.ToInt32(Console.ReadLine());

            if (Input2 == 1)
            {
                //Creating a new Book
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("===================");
                Console.WriteLine("Creating a new book");
                Console.WriteLine("===================");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|| Write the title of the book:");
                //Method too create a book
                
            }
        }

        else if (Input1 == 2)
        {
            //Reading menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("============");
            Console.WriteLine("Reading menu");
            Console.WriteLine("============");
        }

        else if (Input1 ==3)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("===================");
            Console.WriteLine("Wish you a good day");
            Console.WriteLine("===================");
        }

        else
        {
            return;
        }
            //Create a Book (Datasave json)
            //Choose a book/text
        */
    }
    public static void JsonToFile(object Object, string path)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string json = JsonSerializer.Serialize(Object, typeof(Object), options);
        File.WriteAllText(path, json);
    }
}