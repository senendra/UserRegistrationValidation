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
        public string regrexEmail = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public bool ValidatingEmail(string emailId)
        {
            return Regex.IsMatch(emailId, regrexEmail);
        }
    }
}
