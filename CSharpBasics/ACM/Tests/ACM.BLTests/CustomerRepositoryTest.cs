using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            CustomerRepo cs = new CustomerRepo();
            var expected = new Customer(1)
            {
                EmailAddress = "Abhi@yahoo.com",
                FirstName = "Abhiroop",
                LastName = "Mukherjee"
            };

            //Act
            var actual = cs.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //Arrange
            CustomerRepo cs = new CustomerRepo();
            var expected = new Customer(1)
            {
                EmailAddress = "Abhi@yahoo.com",
                FirstName = "Abhiroop",
                LastName = "Mukherjee",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "street11",
                        StreetLine2 = "street22",
                        City = "kolkata2",
                        State = "WB2",
                        Country = "India2",
                        PostalCode = "560036"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "street111",
                        StreetLine2 = "street222",
                        City = "kolkata22",
                        State = "WB22",
                        Country = "India22",
                        PostalCode = "560037"
                    }
                }
            };

            //Act
            var actual = cs.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for(int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
