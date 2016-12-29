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
            var types= new WebClient().DownloadString("http://api.fixer.io/latest?base=USD");
            Doviz kur = JsonConvert.DeserializeObject<Doviz>(types);
            Console.WriteLine("hangi dovizden donusum yapılacak");
            String input = Console.ReadLine();
            Console.WriteLine("miktari giriniz");
            String miktar = Console.ReadLine();
            int deger1 = int.Parse(miktar);
            Console.WriteLine(deger1);
            double deger2 = deger1 * (kur.Rates[input]);
            Console.WriteLine(deger2);
            Console.Read();
        }
    }
    public class Doviz {
        public string Base { get; set; }
        public string Date { get; set; }
        public Dictionary<string,double>Rates; 
    }
    
}
 
