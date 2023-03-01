namespace BookGoodTextPassages;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        //Introduction
        Console.WriteLine("Welcome to my program!");
        Thread.Sleep(2000);
        Console.WriteLine("I will show you all the Book passages that toucht me deeply");
        Thread.Sleep(2000);
        Console.WriteLine("And you can write some too...");
        Thread.Sleep(5000);
        Console.Clear();
        //Menu
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Welcome to the menu");
        Console.WriteLine("===================");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("|| Wanna write something?");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("|| Press [ 1 ]");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("|| Wanna read something?");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("|| Press [ 2 ]");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("||Wanna quit?");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("||Press [ 3 ]");
        int Input1 = Convert.ToInt32(Console.ReadLine());

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
    }
}

class input
{

}