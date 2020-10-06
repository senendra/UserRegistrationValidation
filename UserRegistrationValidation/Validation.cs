using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationValidation
{
    class Validation
    {
        public string regrexFirstName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidatingFirstName( string firstName)
        {
            return Regex.IsMatch(firstName, regrexFirstName);
        }
    }
}
