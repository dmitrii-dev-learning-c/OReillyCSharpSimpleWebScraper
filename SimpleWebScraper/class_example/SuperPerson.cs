using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper.ClassExample
{
    class SuperPerson : Person
    {

        public SuperPerson(string snn, string passportData, string drivingLicenseNumber) :
            base(snn, passportData, drivingLicenseNumber)
        {

        }

        public void SaveToDatabase()
        {
            //accessing protect data:
            otherMetadata = "bla bla bla";

            // Logic to save the person to a database
            Console.WriteLine("Saving SuperPerson to database...");
        }

    }
}
