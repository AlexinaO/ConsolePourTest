namespace ConsolePourTest.Entities
{
    public class CartLine
    {
        //public int Id { get; set; } pas utile si on ne met pas en base !

        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}