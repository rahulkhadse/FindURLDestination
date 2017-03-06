using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace FindURLDestination
{
    class Program
    {

        static void Main(string[] args)
        {
            string urls = "COMMA SEPERATED URLS ";

            var list = urls.Split(',').ToArray();
            foreach (var r in list)
            {
                string redirectedURL = WebRequest.Create(r)
                                     .GetResponse()
                                     .ResponseUri
                                     .ToString();

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("original url : " + r + "   ");
                Console.Write("dest url : " + redirectedURL);
                Console.WriteLine("");
            }
            

        }
    }
}
