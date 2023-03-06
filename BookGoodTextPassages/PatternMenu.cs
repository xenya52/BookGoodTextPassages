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
        /* Attributes */
        public string PatternHeadline { get; set; } = "";
        public string[] PatternText { get; set; } = new string[5];

        /*Etc*/
        private string Line = "";

        /* Methods */
        public void PatternHeadLineMethod () // HeadLine
        {
            for (int i = 0; i < PatternHeadline.Length; i++) //Makeing the Line with the same length as the HeadLine
            {
                Line = Line.Insert(i, "=");
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine (Line);
            Console.WriteLine (PatternHeadline);
            Console.WriteLine (Line);
        }
        public void PatternTextMethod () // Text and Declaration
        {
            for (int i = 0; i < PatternText.Length;i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("|| " + PatternText);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("|| Write : [ " + PatternPress + " ]");
            }
        }
    }
}
