using System;
namespace UserRegistrationValidation
{
    public class Program
    {
        static void Main(string[] args)
        { 
            string firstName = "Senendra" ;
            string lastName = "Deshlahre";
            string emailId = "abc.xyz@bl.co.in";
            string phoneNumber = "91 9000003215";
            string password = "Password@123";
            Console.Write(firstName);
            Validation check = new Validation();
            bool result = check.ValidatingName(firstName);
            check.Display(result);
            result = check.ValidatingName(lastName);
            Console.Write(lastName);
            check.Display(result);
            result = check.ValidatingEmail(emailId);
            Console.Write(emailId);
            check.Display(result);
            result = check.ValidatingPhoneNumber(phoneNumber);
            Console.Write(phoneNumber);
            check.Display(result);
            result = check.ValidatingPassword(password);
            Console.Write(password);
            check.Display(result);
            Console.WriteLine("\nChecking for sample mails :\n");
            foreach (string mail in check.GetList())
            {
                Console.Write(mail + " : ");
                result = check.ValidatingEmail(mail);
                check.Display(result);
            }
        }
    }
}
