using ConsolePourTest.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsolePourTestTests
{
    [TestClass]
    public class ProductTest
    {
        [DataTestMethod]
        [DataRow("0")]
        [DataRow("-1")]
        public void ValidatePrice(string rawPrice)
        {
            var price = decimal.Parse(rawPrice);
            var exception = Assert.ThrowsException<Exception>(() =>
            {
                var product = new Product
                {
                    Name = "Bouteille Bordeaux",
                    Price = price
                };
            });
            Assert.AreEqual("Prix ne peut pas être négatif", exception.Message);
        }

        [TestMethod]
        public void NoNameEmpty()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var product = new Product
                {
                    Name = "",
                    Price = 10
                };
                product.Validate();
            });
        }
    }
}