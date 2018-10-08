using System;

namespace ConsolePourTest.Entities
{
    public class Product
    {
        private decimal price;

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prix ne peut pas être négatif");
                price = value;
            }
        }

        public void Validate()
        {
            if (Price <= 0)
                throw new Exception("Prix ne peut pas être négatif");
            if (string.IsNullOrWhiteSpace(Name))
                throw new Exception("Nom est requis");
        }
    }
}