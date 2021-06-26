using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTest()
        {
            //Arrange
            Customer cust = new Customer
            {
                FirstName = "Abhiroop",
                LastName = "Mukherjee"
            };
            string expected = "Mukherjee,Abhiroop";
            //Act
            string actual = cust.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LastNameEmpty()
        {
            //Arrange
            Customer cust = new Customer
            {
                FirstName = "Abhiroop"
            };
            string expected = "Abhiroop";
            //Act
            string actual = cust.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValid()
        {
            //Arrange
            Customer cust = new Customer();
            cust.LastName = "Abhiroop";
            cust.EmailAddress = "Abhi";
            var isValid = cust.Validate();

            //Act
            bool expected = true;

            //Assert
            Assert.AreEqual(expected, isValid);
        }
    }
}
