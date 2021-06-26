using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
using System.Collections.Generic;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Xunit;

namespace Test
{

    [TestClass]
    public class BookTests
    {
        [TestMethod]
        public void Test1()
        {
            //arrange
            var book = new InMemoryBook("bookTest1");
            List<double> l = new List<double>() { 89.1, 90.5, 77.3 };
            book.AddGrade(l);

            //act
            //book.GetStats();
            var result = book.BookStats();

            //assert
            Assert.AreEqual(90.5, result.high,1);
            Assert.AreEqual(77.3, result.low,1);
            Assert.AreEqual(85.6, result.average,1);

        }
    }
}
