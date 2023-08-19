using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp1
{
    internal class Driver
    {
        // Validation
        private Regex sampleName = new Regex(@"^[A-Za-z ]+$", RegexOptions.IgnoreCase);
        private Regex SampleDob = new Regex(@"^\d{2}/\d{2}/\d{4}$", RegexOptions.IgnoreCase);
        private Regex SampleHeight = new Regex(@"\d$", RegexOptions.IgnoreCase);
        private Regex SampleLicNumber = new Regex(@"[A-Za-z]\d{4}-\d{5}-\d{4}$", RegexOptions.IgnoreCase);
        
        // Declaring string
        public string Name;
        public string dob;
        public string height;
        public string dLicNumber;

        public Driver(string driverName, string driverDob,string driverHeight,string driverLicNumber)
        {

            if(driverValidation(driverName, driverDob, driverHeight, driverLicNumber))
            {
                // Assigining different string 
                dName = driverName;
                dDob = driverDob;
                dHeight = driverHeight;
                dLicNumber = driverLicNumber;
            }

        }

        private bool driverValidation(string valid, string t1, string t2, string t3)
        {
            // Checking driver validation
            string errors = "";

            // Validating Name
            if (string.IsNullOrEmpty(valid))
                errors += "Name cannot be null or empty\n";
            else if (!sampleName.IsMatch(valid))
                errors += "Name should be alphabet only\n";

            // Validating Date of Birth
            if (string.IsNullOrEmpty(t1))
                errors += "DOB cannot be null or empty\n";
            else if (!SampleDob.IsMatch(t1))
                errors += "Date of birth must follow this format : dd/mm/yyyy\n";

            // Validating Height
            if (string.IsNullOrEmpty(t2))
                errors += "Height cannot be null or empty\n";
            else if (!SampleHeight.IsMatch(t2))
                errors += "Height can't be alphabet\n";
            
            // Validating Licence Number
            if (string.IsNullOrEmpty(t3))
                errors += "Licence Number cannot be null or empty\n";
            else if (!SampleLicNumber.IsMatch(t3))
                errors += "Licence number should followed this format :  A1111-22222-3333\n";

            // Displaying Errors
            if (errors != "")
            {
                throw new InvalidDataException(errors);
            }
            else
            {
                return true;
            }

        }

        //getting all the string
        public string dName { get; }
        public string dDob { get; }
        public string dHeight { get; }
        public string LicenceNumber { get; }
    }
}
