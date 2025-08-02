using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebScraper.ClassExample
{
    class Person
    {
        string _ssn;
        string _passportData;
        string _drivingLicenseNumber;

        //protected means - otherMetadata can only be accessed from within this class OR
        // form any other class that is inheriting from Person class
        protected string otherMetadata { get; set; }


        public Person(string snn, string passportData, string drivingLicenseNumber)
        {
            // Constructor logic:
            _ssn = snn;
            _passportData = passportData;
            _drivingLicenseNumber = drivingLicenseNumber;


        }

        public bool HasProperDocuments { 
            get
            { 
                return _ssn.Length > 0 && _passportData.Length > 0 && _drivingLicenseNumber.Length > 0;
            } 
        }

        
    }
}
