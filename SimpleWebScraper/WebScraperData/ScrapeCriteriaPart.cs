using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.WebScraperData
{
    internal class ScrapeCriteriaPart
    {

        public string RegEx { get; set; }
        public RegexOptions RegExOptions { get; set; }
    }
}
