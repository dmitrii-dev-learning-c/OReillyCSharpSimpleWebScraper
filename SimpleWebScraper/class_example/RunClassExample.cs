using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper.ClassExample
{
    class RunClassExample
    {

        public static void Run()
        {
            Person person = new Person("SSN", "Data", "More Data");
            Console.WriteLine($"Person has proper documents: {person.HasProperDocuments}");




            // Inheritance Example:
            SuperPerson superPerson = new SuperPerson("SSN", "Data", "More Data");

            Console.WriteLine(superPerson.HasProperDocuments);
            superPerson.SaveToDatabase();
        }
    }
}
