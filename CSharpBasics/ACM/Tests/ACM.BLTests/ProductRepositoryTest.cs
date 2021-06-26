using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;

namespace ACM.BLTests
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-Arrange
            var productRepository = new ProductRepo();
            var expected = new Product(2)
            {
                CurrentPrince = 15.96M,
                ProductDescription = "Mini sunflowers",
                ProductName = "Sunflowers"
            };

            //-Act
            var actual = productRepository.Retrieve(2);

            //-Assert
            Assert.AreEqual(expected.CurrentPrince, actual.CurrentPrince);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
        }
        [TestMethod]
        public void SaveTestPositive()
        {
            //-Arrange
            var productRepository = new ProductRepo();
            var updateProduct = new Product(2)
            {
                CurrentPrince = 15.96M,
                ProductDescription = "Mini sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-Act
            var actual = productRepository.Save(updateProduct);

            //-Assert
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //-Arrange
            var productRepository = new ProductRepo();
            var updateProduct = new Product(2)
            {
                CurrentPrince = null,
                ProductDescription = "Mini sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-Act
            var actual = productRepository.Save(updateProduct);

            //-Assert
            Assert.AreEqual(false, actual);
        }
    }
}
