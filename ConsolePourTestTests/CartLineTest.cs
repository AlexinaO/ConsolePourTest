using ConsolePourTest.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsolePourTestTests
{
    [TestClass]
    public class CartLineTest
    {
        [TestMethod]
        public void ValidatePositiveQuantity()
        {
            var cartLine = new CartLine
            {
                Product = new Product(),
                Quantity = -1
            };
            var exception = Assert.ThrowsException<Exception>(() => cartLine.Validate());
            Assert.AreEqual("Quantité doit être positive", exception.Message);
        }

        [TestMethod]
        public void ValidateInfoProduct()
        {
            var cartLine = new CartLine
            {
                Product = null,
                Quantity = 1
            };
            var exception = Assert.ThrowsException<Exception>(() => cartLine.Validate());
            Assert.AreEqual("Produit est requis", exception.Message);
        }
    }
}