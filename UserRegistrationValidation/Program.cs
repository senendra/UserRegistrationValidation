using System;
namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        { 
            string firstName = "Senendra" ;
            string lastName = "Deshlahre";
            Console.WriteLine(firstName);
            Validation check = new Validation();
            bool result = check.ValidatingName(firstName);
            Console.WriteLine(result);
            result = check.ValidatingName(lastName);
            Console.WriteLine(lastName);
            Console.WriteLine(result);

        }
    }
}
