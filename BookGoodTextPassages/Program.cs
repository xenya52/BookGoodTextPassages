using BookGoodTextPassages;

class Program
{
    static void Main(string[] args)
    {
        Book EssaysDieDeinLebenVerändern = new Book();

        //Introduction
        Console.WriteLine("Welcome to my program!");
        Thread.Sleep(5000);
        Console.WriteLine("I will show you all the Book passages that toucht me deeply");
        Thread.Sleep(5000);
        Console.WriteLine("Do you want to continue, please write - Yes -");
        string Yes1 = Convert.ToString(Console.ReadLine());

        if (Yes1 == "Yes")
        {
            Console.WriteLine("To select the Language, type the right number please");
            int Number1 = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bye...");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}