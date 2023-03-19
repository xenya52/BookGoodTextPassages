using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookGoodTextPassages
{
    internal class PatternMenu
    {
        /*MyPublicMethods*/
        public void PatternHeadLineMethod (string PatternHeadline) // HeadLine
        {
            string Line = "";
            for (int i = 0; i < PatternHeadline.Length; i++) // Makeing the Line with the same length as the HeadLine
            {
                Line = Line.Insert(i, "=");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine (Line);
            Console.WriteLine (PatternHeadline);
            Console.WriteLine (Line);
            Console.WriteLine();
        }
        public void PatternTextMethod(string PatternText, int Number)
        {
            string Line = "";
            for (int i = 0; i < PatternText.Length; i++) // Makeing the Line with the same length as the HeadLine
            {
                Line = Line.Insert(i, "=");
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Line);
            Console.WriteLine(PatternText);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Write: [ " + Number + " ]");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Line);
            Console.WriteLine ();
        }
    }
}
