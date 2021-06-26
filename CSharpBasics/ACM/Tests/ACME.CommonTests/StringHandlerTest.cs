using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACME.CommonTests
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpaceTest()
        {
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void InsertExistingSpaceTest()
        {
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //var actual = StringHandler.InsertSpaces(source);
            var actual = source.InsertSpaces();

            Assert.AreEqual(expected, actual);
        }
    }
}
