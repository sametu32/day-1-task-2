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
            var Doviz_listesi = JsonConvert.DeserializeObject<Bilgi[]>(json);
            foreach(Bilgi i in Doviz_listesi)
            {
                Console.WriteLine(i.name);
                Console.Write(i.cc);
                Console.Write(i.symbol);
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
