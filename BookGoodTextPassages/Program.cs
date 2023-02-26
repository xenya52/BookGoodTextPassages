using BookGoodTextPassages;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Book EssaysDieDeinLebenVerändern = new Book();

        //Introduction
        Console.WriteLine("Welcome to my program!");
        Thread.Sleep(2000);
        Console.WriteLine("I will show you all the Book passages that toucht me deeply");
        Thread.Sleep(2000);
        Console.WriteLine("Do you want to continue, please write - Yes -");
        string Yes1 = Convert.ToString(Console.ReadLine());

        if (Yes1 == "Yes")
        {
            //Language selection
            Console.WriteLine("To select the Language, type the right number please");
            Console.WriteLine("1 = Eng");
            Console.WriteLine("2 = Ger");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            
            //Choosen Language Englisch
            if (Number1 == 1) { }
            //Choosen Language German
            else if (Number1 == 2) 
            { 
                Book xEssaysDieDeinLebenVerändern = new Book();
                //Creating my text passages
                Console.WriteLine("Now you can write you good phrases");
                xEssaysDieDeinLebenVerändern.createinput();
            }
            
            //No valid input
            else
            {
                return;
            }
        }
        else
        {
            //Bye...
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bye...");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}