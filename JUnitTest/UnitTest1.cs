using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationValidation;
namespace JUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        //Happy: Testing for Valid Details
        [TestMethod]
        public void HappyFirstNameTest()
        {
            //Arrange
            string firstName = "Senendra";
            Validation test = new Validation();
            //Act
            bool firstNameResult = test.ValidatingName(firstName);
            //Assert
            Assert.IsTrue(firstNameResult);
        }
        [TestMethod]
        public void HappyLastNameTest()
        {
            //Arrange
            string lastName = "Deshlahre";
            Validation test = new Validation();
            //Act
            bool lastNameResult = test.ValidatingName(lastName);
            //Assert
            Assert.IsTrue(lastNameResult);
        }
        [TestMethod]
        public void HappyPhoneNumberTest()
        {
            //Arrange
            string phoneNumber = "91 1236547892";
            Validation test = new Validation();
            //Act
            bool phoneNumberResult = test.ValidatingPhoneNumber(phoneNumber);
            //Assert
            Assert.IsTrue(phoneNumberResult);
        }
        [TestMethod]
        public void HappyEmailTest()
        {
            //Arrange
            string email = "abc.xyz@gmail.com";
            Validation test = new Validation();
            //Act
            bool emailResult = test.ValidatingEmail(email);
            //Assert
            Assert.IsTrue(emailResult);
        }
        [TestMethod]
        public void HappyPasswordTest()
        {
            //Arrange
            string password = "Password@12343";
            Validation test = new Validation();
            //Act
            bool passwordResult = test.ValidatingPassword(password);
            //Assert
            Assert.IsTrue(passwordResult);
        }

        //Sad: Testing for Invalid Details
        [TestMethod]
        public void SadFirstNameTest()
        {
            //Arrange
            string firstName = "senendra";
            Validation test = new Validation();
            //Act
            bool firstNameResult = test.ValidatingName(firstName);
           //Assert
            Assert.IsFalse(firstNameResult);
        }
        [TestMethod]
        public void SadLastNameTest()
        {
            //Arrange
            string lastName = "deshlahre";
            Validation test = new Validation();
            //Act
            bool lastNameResult = test.ValidatingName(lastName);
           //Assert
            Assert.IsFalse(lastNameResult);
        }
        [TestMethod]
        public void SadPhoneNumberTest()
        {
            //Arrange
            string phoneNumber = "01 1236547892";
            Validation test = new Validation();
            //Act
            bool phoneNumberResult = test.ValidatingPhoneNumber(phoneNumber);
            //Assert
            Assert.IsFalse(phoneNumberResult);
        }
        [TestMethod]
        public void SadEmailTest()
        {
            //Arrange
            string email = "abc.xyz.@gmail.com";
            Validation test = new Validation();
            //Act
            bool emailResult = test.ValidatingEmail(email);
            //Assert
            Assert.IsFalse(emailResult);
        }
        [TestMethod]
        public void SadPasswordTest()
        {
            //Arrange
            string password = "password@@12343";
            Validation test = new Validation();
            //Act
            bool passwordResult = test.ValidatingPassword(password);
           //Assert
            Assert.IsFalse(passwordResult);
        }
    }
}
