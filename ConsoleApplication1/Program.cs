using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace ConsoleApplication1
{
    class Program
    {
        private void JSONSerilaize()
        {
            
        }
        static void Main(string[] args)
        {
            // Serializaion  
            Lesson ders = new Lesson();
            ders.Name = "Manas";
            ders.Code = "India";

            // Convert Employee object to JOSN string format   
            string jsonData = JsonConvert.SerializeObject(ders);

            Console.Write(jsonData);
            Console.Read();
        }
    }
    public class Lesson {

        public string Name { get; set; }
        public string Code { get; set; }

    }
 
}
