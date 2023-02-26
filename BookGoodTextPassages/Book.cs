using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookGoodTextPassages
{
    internal class Book
    {
        public string[] book { get; set; } = new string[50];

        public void createinput()
        {
            for (int i = 0; i < book.Length; i++)
            {
                book[i] = Convert.ToString(Console.ReadLine());
            }
        }

        public void site1()
        {
            Console.WriteLine("||Site.1||");
            Console.WriteLine("||" + book[0]);
            Console.WriteLine("||" + book[1]);
            Console.WriteLine("||" + book[2]);
            Console.WriteLine("||" + book[3]);
            Console.WriteLine("||" + book[4]);
            Console.WriteLine("||" + book[5]);
            Console.WriteLine("||" + book[6]);
            Console.WriteLine("||" + book[7]);
            Console.WriteLine("||" + book[8]);
            Console.WriteLine("||" + book[9]);
        }
        public void site2()
        {
            Console.WriteLine("Site.2");
            Console.WriteLine("||" + book[10]);
            Console.WriteLine("||" + book[11]);
            Console.WriteLine("||" + book[12]);
            Console.WriteLine("||" + book[13]);
            Console.WriteLine("||" + book[14]);
            Console.WriteLine("||" + book[15]);
            Console.WriteLine("||" + book[16]);
            Console.WriteLine("||" + book[17]);
            Console.WriteLine("||" + book[18]);
            Console.WriteLine("||" + book[19]);
        }
        public void site3()
        {
            Console.WriteLine("Site.3");
            Console.WriteLine("||" + book[20]);
            Console.WriteLine("||" + book[21]);
            Console.WriteLine("||" + book[22]);
            Console.WriteLine("||" + book[23]);
            Console.WriteLine("||" + book[24]);
            Console.WriteLine("||" + book[25]);
            Console.WriteLine("||" + book[26]);
            Console.WriteLine("||" + book[27]);
            Console.WriteLine("||" + book[28]);
            Console.WriteLine("||" + book[29]);
        }
        public void site4()
        {
            Console.WriteLine("Site.4");
            Console.WriteLine("||" + book[30]);
            Console.WriteLine("||" + book[31]);
            Console.WriteLine("||" + book[32]);
            Console.WriteLine("||" + book[33]);
            Console.WriteLine("||" + book[34]);
            Console.WriteLine("||" + book[35]);
            Console.WriteLine("||" + book[36]);
            Console.WriteLine("||" + book[37]);
            Console.WriteLine("||" + book[38]);
            Console.WriteLine("||" + book[39]);
        }
        public void site5()
        {
            Console.WriteLine("Site.5");
            Console.WriteLine("||" + book[40]);
            Console.WriteLine("||" + book[41]);
            Console.WriteLine("||" + book[42]);
            Console.WriteLine("||" + book[43]);
            Console.WriteLine("||" + book[44]);
            Console.WriteLine("||" + book[45]);
            Console.WriteLine("||" + book[46]);
            Console.WriteLine("||" + book[47]);
            Console.WriteLine("||" + book[48]);
            Console.WriteLine("||" + book[49]);
        }
    }
}
