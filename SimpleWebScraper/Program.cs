using System;

using SimpleWebScraper.ClassExample;

using SimpleWebScraper.UsingExample;

using SimpleWebScraper.regularex_example;

using SimpleWebScraper.HumanBuilderExample;
using System.Net;
using SimpleWebScraper.WebScraperData;
using SimpleWebScraper.WebScraperBuilder;
using System.Text.RegularExpressions;
using SimpleWebScraper.WebScraperWorkers;
using System.Linq;

namespace SimpleWebScraper
{
    internal class Program
    {

        private const string Method = "search";
        static void Main(string[] args)
        {
            //Class Fields and Properties Example:
            RunClassExample.Run();

            //Running Using Example - Downloading Google's main page:
            //UsingExampleClass.RunUsingExample();

            //Running Human Builder Example (calling Non static method):
            var runner = new HumanBuilderRunner();
            runner.Run();

            //Running Regular Expression Example:
            RegularExpression regularExpression = new RegularExpression();
            regularExpression.RegularExpressionExample();


            Console.WriteLine("Welcome to the Simple Web Scraper: ");

            try
            {
                Console.WriteLine("Please Enter which city you would like to scrape info from: ");
                var craigsListCity = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Please Enter the Craigslist category that you woud like to scrape: ");
                var craigsListCategoryName = Console.ReadLine() ?? string.Empty;

                using (WebClient client = new WebClient())
                {
                    string content = client.DownloadString
                        ($"http://{craigsListCity.Replace(" ", string.Empty)}.craigslist.org/{Method}/{craigsListCategoryName}");

                    ScraperCriteria criteria = new ScrapeCriteriaBuilder()
                        .WithData(content)
                        .WithRegEx(@"<a href=\""(.*?)\"" data-id=\""(.*?)\"" class=\""result-title hdrlnk\"">(.*?)</a>")
                        .WithRegExOptions(RegexOptions.ExplicitCapture)
                        .WithParts(new PartsCriteriaBuilder()
                            .WithRegEx(@">(.*?)</a>")
                            .WithRegExOptions(RegexOptions.Singleline)
                            .Build())
                        .WithParts(new PartsCriteriaBuilder()
                            .WithRegEx(@"href=\""(.*?)\""")
                            .WithRegExOptions(RegexOptions.Singleline)
                            .Build())
                        .Build();


                    Scraper scraper = new Scraper();
                    var scrapedElements = scraper.Scrape(criteria);
                    if (scrapedElements.Any())
                    {
                        foreach (var scrapedElement in scrapedElements)
                        {
                            Console.WriteLine(scrapedElement);
                        }

                    }
                    else
                    {
                        Console.WriteLine("There were no matches for the specified criteria");
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           

        }
    }
}
