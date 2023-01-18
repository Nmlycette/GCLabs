using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using System.Xml.Linq;

namespace CoffeeShopProductList.Models
{
    public class ProductViewModel
    {
        [DisplayName("Item Id")]
        public int id { get; set; }

        [DisplayName("Name")]
        public string? name { get; set; }
        
        [DisplayName("Description")]
        public string? description { get; set; }
        
        [DisplayName("Price")]
        public decimal price { get; set; }

        [DisplayName("Category")]
        public string? category { get; set; }
    }
}
