using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json; //Speichere die Datei in einem Json Dokument
using System.IO;
using System.Threading.Tasks;

namespace BookGoodTextPassages
{
    internal class Root
    {
        public string[,] BookQuotes = new string[2, 2]
        {
        {"b","a"},
        {"c","d"}
        };
    }
}
