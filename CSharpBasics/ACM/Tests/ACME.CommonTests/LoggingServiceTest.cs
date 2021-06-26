using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.CommonTests
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "Abhi@yahoo.com",
                FirstName = "Abhiroop",
                LastName = "Mukherjee",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                CurrentPrince = 15.96M,
                ProductDescription = "Mini sunflowers",
                ProductName = "Sunflowers"
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }

    }
}
