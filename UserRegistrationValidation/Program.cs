using System;
namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        { 
            string firstName = "senendra" ;
            Console.WriteLine(firstName);
            Validation check = new Validation();
            bool result = check.ValidatingFirstName(firstName);
            Console.WriteLine(result);
        }
    }
}
