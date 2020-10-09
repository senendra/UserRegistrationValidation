using System;
namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        { 
            string firstName = "Senendra" ;
            string lastName = "Deshlahre";
            string emailId = "abc.xyz@bl.co.in";
            string phoneNumber = "91 9000003215";
            string password = "psSs12@-jg";
            Console.WriteLine(firstName);
            Validation check = new Validation();
            bool result = check.ValidatingName(firstName);
            Console.WriteLine(result);
            result = check.ValidatingName(lastName);
            Console.WriteLine(lastName);
            Console.WriteLine(result);
            result = check.ValidatingEmail(emailId);
            Console.WriteLine(emailId);
            Console.WriteLine(result);
            result = check.ValidatingPhoneNumber(phoneNumber);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(result);
            result = check.ValidatingPassword(password);
            Console.WriteLine(password);
            Console.WriteLine(result);
        }
    }
}
