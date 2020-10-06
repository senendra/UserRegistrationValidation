using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationValidation
{
    class Validation
    {
        public string regrexName = "^[A-Z]{1}[a-z]{2,}$";
        public bool ValidatingName( string name)
        {
            return Regex.IsMatch(name, regrexName);
        }
    }
}
