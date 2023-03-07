namespace BookGoodTextPassages;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        /*Introduction*/
        Console.WriteLine("Welcome to my program!");
        Thread.Sleep(2000);
        Console.WriteLine("I will show you all the Book passages that toucht me deeply");
        Thread.Sleep(2000);
        Console.WriteLine("And you can write some too...");
        Thread.Sleep(5000);
        Console.Clear();

        //MainMenu
        PatternMenu MainMenu = new();
        MainMenu.PatternHeadLineMethod("MainMenu");
        MainMenu.PatternTextMethod("Wanna write something", 1);
        MainMenu.PatternTextMethod("Wanna read something", 2);
        MainMenu.PatternTextMethod("Wanna quit the software", 3);
        int InputMain = 0;
            InputMain = Convert.ToInt32(Console.ReadLine());
        if (InputMain == 1) 
        {
        }
        else if (InputMain == 2)
        {

        }
        else if (InputMain == 3)
        {
        }
        else { Console.WriteLine("Error"); }






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
}