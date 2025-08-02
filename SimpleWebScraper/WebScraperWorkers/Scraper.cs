using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using SimpleWebScraper.WebScraperData;

namespace SimpleWebScraper.WebScraperWorkers
{
    internal class Scraper
    {

        public List<string> Scrape(ScraperCriteria criteria)
        {
            List<string> scrappedElements = new List<string>();

            MatchCollection matches = Regex.Matches(criteria.Data, criteria.RegEx, criteria.RegExOptions);

            foreach(Match match in matches)
            {
                if (!criteria.Parts.Any())
                {
                    scrappedElements.Add(match.Groups[0].Value);
                }
                else
                {
                    foreach (var part in criteria.Parts){
                        Match matchedPart = Regex.Match(match.Groups[0].Value, part.RegEx, part.RegExOptions);

                        if (matchedPart.Success)
                        {
                            scrappedElements.Add(matchedPart.Groups[1].Value);
                        }
                    }
                }
            }

            return scrappedElements;
        }
    }
}
