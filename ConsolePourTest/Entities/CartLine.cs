using System;

namespace ConsolePourTest.Entities
{
    public class CartLine
    {
        //public int Id { get; set; } pas utile si on ne met pas en base !

        public Product Product { get; set; }

        public int Quantity { get; set; }

        public void Validate()
        {
            if (Quantity < 0)
                throw new Exception("Quantité doit être positive");
            if (Product == null)
                throw new Exception("Produit est requis");
        }
    }
}