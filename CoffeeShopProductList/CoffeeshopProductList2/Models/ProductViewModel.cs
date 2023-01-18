namespace CoffeeShopProductList.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string? description { get; set; } 
        public double price { get; set; }
        public string? category { get; set; }
    }
}
