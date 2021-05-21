namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        public int Qunatity { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public string ProductId { get; set; }

        public string ProductName { get; set; }
    }
}