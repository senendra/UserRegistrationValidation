using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationValidation
{
    class Validation
    {
        public string regexName = "^[A-Z]{1}[a-z]{2,}$";
        public string regexPhoneNumber = "^[1-9]{1}[0-9]{1}[ ]([1-9]{1}[0-9]{9})$";
        public string regexEmail = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public string regexPassword = "^[A-Za-z0-9^!@#$%&+-.]{8,}$";
        public bool ValidatingName( string name)
        {
            return Regex.IsMatch(name, regexName);
        }
        public bool ValidatingEmail(string emailId)
        {
            return Regex.IsMatch(emailId, regexEmail);
        }      
        public bool ValidatingPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, regexPhoneNumber);
        }      
        public bool ValidatingPassword(string password)
        {
            return Regex.IsMatch(password, regexPassword);
        }
    }
}
