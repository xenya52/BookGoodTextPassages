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
        /*Attributes*/
        //JsonToFile tutorial https://www.youtube.com/watch?v=BwQZbmwVEWA
        public string Name { get; set; }
        public string Description { get; set; }
        /*Methods*/
        public static void JsonToFile(object Object, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            string json = JsonSerializer.Serialize(Object);
            File.WriteAllText(path, json);
        }
    }
}
