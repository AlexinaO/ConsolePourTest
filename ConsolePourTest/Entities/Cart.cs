using System.Collections.Generic;
using System.Linq;

namespace ConsolePourTest.Entities
{
    public class Cart
    {
        public Cart()
        {
            Lines = new List<CartLine>();
        }

        public List<CartLine> Lines { get; set; }

        public decimal ShippingCost { get; set; } = 10;

        public decimal GetTotal()
        {
            var totalLines = Lines.Sum(x => x.Product.Price * x.Quantity);
            return totalLines + ShippingCost;
        }
    }
}