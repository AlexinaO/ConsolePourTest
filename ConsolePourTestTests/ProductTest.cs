using ConsolePourTest.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsolePourTestTests
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void NoPriceInfOrEqual0()
        {
            var exception = Assert.ThrowsException<Exception>(() =>
            {
                var product = new Product
                {
                    Name = "Bouteille Bordeaux",
                    Price = 0
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