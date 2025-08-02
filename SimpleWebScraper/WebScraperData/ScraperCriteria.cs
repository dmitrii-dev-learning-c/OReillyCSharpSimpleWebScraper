using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.WebScraperData
{
    internal class ScraperCriteria
    {
        public ScraperCriteria()
        {
            Parts = new List<ScrapeCriteriaPart>();

        }

        public string Data { get; set; }
        public string RegEx { get; set; }

        public RegexOptions RegExOptions { get; set; }
        public List<ScrapeCriteriaPart> Parts { get; set; }


    }
}
