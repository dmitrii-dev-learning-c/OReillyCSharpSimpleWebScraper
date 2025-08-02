using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper.HumanBuilderExample
{
    internal class HumanBuilderRunner
    {
        internal void Run()
        {
            //Faster way to create Human objects using the Builder pattern:
            Human h1 = new HumanBuilder().Build();
            Human h2 = new HumanBuilder().WithAge(35).Build();
            Human h3 = new HumanBuilder().WithAge(39).Build();
        }
    }
}
