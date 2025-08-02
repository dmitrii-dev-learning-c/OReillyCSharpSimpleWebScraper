using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using SimpleWebScraper.WebScraperData;

namespace SimpleWebScraper.WebScraperBuilder
{
    internal class ScrapeCriteriaBuilder
    {

        private string _data;
        private string _regEx;
        private RegexOptions _regExOptions;
        private List<ScrapeCriteriaPart> _parts;

        public ScrapeCriteriaBuilder()
        {
            SetDefaults();
        }

        private void SetDefaults()
        {
            _data = string.Empty;
            _regEx = string.Empty;
            _regExOptions = RegexOptions.None;
            _parts = new List<ScrapeCriteriaPart>();
        }

        public ScrapeCriteriaBuilder WithData(string data)
        {
            _data = data;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegEx(string regEx)
        {
            _regEx = regEx;
            return this;
        }

        public ScrapeCriteriaBuilder WithRegExOptions(RegexOptions regExOptions)
        {
            _regExOptions = regExOptions;
            return this;
        }

        public ScrapeCriteriaBuilder WithParts(ScrapeCriteriaPart part)
        {
            _parts.Add(part);
            return this;
        }

        public ScraperCriteria Build()
        {
            ScraperCriteria criteria = new ScraperCriteria();
            criteria.Data = _data;
            criteria.RegEx = _regEx;
            criteria.RegExOptions = _regExOptions;
            criteria.Parts = _parts;
            return criteria;
        }


    }
}
