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

        public decimal ShippingCost { get; set; }

        public decimal GetTotal()
        {
            if (!Lines.Any())
            {
                return 0;
            }
            var totalLines = Lines.Sum(x => x.Product.Price * x.Quantity);
            ShippingCost = totalLines > 100 ? 0 : 10;
            return totalLines + ShippingCost;
        }

        public void Validate()
        {
            foreach (var line in Lines)
            {
                line.Validate();
            }
        }
    }
}