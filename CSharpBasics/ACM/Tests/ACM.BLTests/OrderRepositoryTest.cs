using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //-Arrange
            var orderRepo = new OrderRepo();
            var expected = new Order()
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-Act
            var actual = orderRepo.Retrieve(10);

            //-Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
