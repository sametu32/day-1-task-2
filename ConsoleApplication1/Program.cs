using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            var json = new WebClient().DownloadString("https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json");
            Console.Write(json);
            var Doviz_listesi = JsonConvert.DeserializeObject<Bilgi[]>(json);
            for(int i=0; i<Doviz_listesi.Length; i++)
            {
            Console.WriteLine(Doviz_listesi[i].name);
            Console.Write(Doviz_listesi[i].symbol);
            Console.Write(Doviz_listesi[i].cc);
            }
            Console.Read();
        }
    }
    public class Bilgi {

        
        public string cc { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
    }
 
}
