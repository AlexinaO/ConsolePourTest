using ConsolePourTest.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTestTests
{
    [TestClass]
    public class CartTest
    {
        [TestMethod]
        public void TotalPriceCalculationWhenEmpty()
        {
            var cart = new Cart();
            Assert.AreEqual(0, cart.GetTotal());
        }

        [TestMethod]
        public void TotalPriceCalculationNormal()
        {
            var cart = new Cart();
            cart.Lines.Add(new CartLine
            {
                Product = new Product
                {
                    Name = "Tronçonneuse",
                    Price = 90
                },
                Quantity = 1
            });
            Assert.AreEqual(100, cart.GetTotal());
        }

        [TestMethod]
        public void NoShippingCostSup100()
        {
            var cart = new Cart();
            cart.Lines.Add(new CartLine
            {
                Product = new Product
                {
                    Name = "Tronçonneuse",
                    Price = 90
                },
                Quantity = 2
            });
            Assert.AreEqual(180, cart.GetTotal());
        }
    }
}