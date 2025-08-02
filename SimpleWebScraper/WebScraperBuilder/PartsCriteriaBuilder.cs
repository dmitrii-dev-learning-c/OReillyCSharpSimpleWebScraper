using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleWebScraper.WebScraperData;

namespace SimpleWebScraper.WebScraperBuilder
{
    internal class PartsCriteriaBuilder
    {

        private string _regEx;
        private RegexOptions _regExOptions;

        public PartsCriteriaBuilder() 
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _regEx = string.Empty;
            _regExOptions = RegexOptions.None;

        }

        public PartsCriteriaBuilder WithRegEx(string regEx)
        {
            _regEx = regEx;
            return this;
        }
        public PartsCriteriaBuilder WithRegExOptions(RegexOptions regExOptions)
        {
            _regExOptions = regExOptions;
            return this;
        }

        public ScrapeCriteriaPart Build()
        {
            ScrapeCriteriaPart parts = new ScrapeCriteriaPart();
            parts.RegEx = _regEx;
            parts.RegExOptions = _regExOptions;
            return parts;
        }

    }
}
