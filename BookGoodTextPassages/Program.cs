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
        bool testloop = true;
        PatternMenu StartMenü = new();
        PatternMenu CreateMenü = new();
        PatternMenu CreateBookMenü = new();
        PatternMenu CreateQuoteMenü = new();
        string UserNavigation = String.Empty;
        CBookCollection createBookCollection = new();
        do
        {
            createBookCollection.BookInputToListMethod();
            JsonToFile(createBookCollection,"BookAndQuotesSave");
        } while (testloop);
        
    }
    public static void JsonToFile(object Object, string path)
    {
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string json = JsonSerializer.Serialize(Object, typeof(Object), options);
        File.WriteAllText(path, json); // Path: C:\Users\Xenmi\Desktop\Software\C# Json\Json\Json\bin\Debug\net6.0
    }
}

/*using System;
using System.Collections.Generic;
using System.Text.Json;//You need to add this
using System.IO; //You need to add this too

namespace Json;
internal class Program
{
static void Main(string[] args)
{
  Config _config = new Config();
  _config.Token = "t0k3n";
  _config.Port = 9966;
  _config.TimeStamp = DateTime.Now;
  _config.Tags = new List<string>() { "string1", "string2", "string3" };
  JsonToFile(_config, "config.json");
  Config ConfigFromFile = ConfigReader("config.json");
  Console.WriteLine(ConfigFromFile.Token); //Watch aigan https://www.youtube.com/watch?v=BwQZbmwVEWA
}
/*ToSaveInAJsonData*//*
      public static void JsonToFile(object Object, string path)
      {
          JsonSerializerOptions options = new JsonSerializerOptions();
          options.WriteIndented = true;
          string json = JsonSerializer.Serialize(Object, typeof(Object), options);
          File.WriteAllText(path, json); // Path: C:\Users\Xenmi\Desktop\Software\C# Json\Json\Json\bin\Debug\net6.0
      }
      /*ToReadAJsonData*//*
      public static Config ConfigReader (string path)
      {
          string json = File.ReadAllText(path);
          return JsonSerializer.Deserialize<Config>(json);
      }
    }
/*Define my Attributes*//*
    public class Config
    {
        public string Token { get; set; }
        public int Port { get; set; }
        public DateTime TimeStamp { get; set; }
        public List<string> Tags { get; set; }
    }

    */