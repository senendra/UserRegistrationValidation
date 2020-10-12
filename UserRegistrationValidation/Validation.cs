using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationValidation
{
    public class Validation
    {
        public string regexName = "^[A-Z]{1}[a-z]{2,}$";
        public string regexPhoneNumber = "^[1-9]{1}[0-9]{1}[ ]([1-9]{1}[0-9]{9})$";
        public string regexEmail = "^[0-9a-zA-Z]{1,}([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]{1,}.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
        public string regexPassword = "^(?=.*?[A-Z])(?=.*?[0-9])(?=[^!@#$%&+-.]*[!@#$%&+-.][^!@#$%&+-.]*$)[\\S]{8,}$";
        List<string> sampleEmail = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
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
        public List<string> GetList()
        {
            return sampleEmail;
        }
        public void Display(bool result)
        {
            string display = (true) ? "Valid" : "Invalid" ;
            Console.WriteLine(" - "+display);
        }
    }
}
