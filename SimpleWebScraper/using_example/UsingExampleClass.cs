using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper.UsingExample
{
    internal class UsingExampleClass
    {
        public static void RunUsingExample()
        {
            //we are giving WebClient the resource we going to use:
            //only valid within the block
            using (WebClient client = new WebClient())
            {
                string googleMainPage = client.DownloadString("http://www.google.com");
                Console.WriteLine(googleMainPage);
            }
        }
    }
}
