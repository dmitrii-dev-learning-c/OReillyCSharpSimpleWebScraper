using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleWebScraper.regularex_example
{
    class RegularExpression
    {
        public void RegularExpressionExample()
        {
            MatchCollection matches = Regex.Matches("This is my rat", "This is my [a-z]at");

            foreach(var match in matches)
            {
                Console.WriteLine($"Found match: {match}");
            }
        }
    }
}
