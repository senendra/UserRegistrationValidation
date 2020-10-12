using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
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
            try
            {
                //Arrange
                string firstName = "senendra";
                Validation test = new Validation();
                //Act
                bool firstNameResult = test.ValidatingName(firstName);     
            }
            catch(UserRegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid first name.", e.Message);
            }
        }
        [TestMethod]
        public void SadLastNameTest()
        {
            try
            {
                //Arrange
                string lastName = "deshlahre";
                Validation test = new Validation();
                //Act
                bool lastNameResult = test.ValidatingName(lastName);
            }
            catch (UserRegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid last name.", e.Message);
            }
        }
        [TestMethod]
        public void SadPhoneNumberTest()
        {
            try
            {
                //Arrange
                string phoneNumber = "01 1236547892";
                Validation test = new Validation();
                //Act
                bool phoneNumberResult = test.ValidatingPhoneNumber(phoneNumber);
            }
            catch(UserRegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid Phone Number.", e.Message);
            }
        }
        [TestMethod]
        public void SadEmailTest()
        {
            try
            {
                //Arrange
                string email = "abc.xyz.@gmail.com";
                Validation test = new Validation();
                //Act
                bool emailResult = test.ValidatingEmail(email);
            }
            catch (UserRegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid Email ID.", e.Message);
            }
        }
        [TestMethod]
        public void SadPasswordTest()
        {
            try
            {
                //Arrange
                string password = "password@@12343";
                Validation test = new Validation();
                //Act
                bool passwordResult = test.ValidatingPassword(password);
            }
            catch (UserRegistrationCustomException e)
            {
                //Assert
                Assert.AreEqual("Invalid Password.", e.Message);
            }
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void JUnitParametrisedTest(string email)
        {
            //Arrange
            Validation test = new Validation();
            //Act
            bool emailResult = test.ValidatingEmail(email);
            //Assert
            Assert.IsTrue(emailResult);
        }
    }
}
