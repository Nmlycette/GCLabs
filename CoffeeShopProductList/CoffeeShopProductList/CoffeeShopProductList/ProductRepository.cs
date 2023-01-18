using CoffeeShopProductList.Models;

namespace CoffeeShopProductList
{
    public class ProductRepository
    {
        private List<ProductViewModel> _mockProducts;

        public ProductRepository()
        {
            CreateMockProductList();
        }

        private void CreateMockProductList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { id = 1, name = "Name Test1", description = "Description1", price = 1.00M, category = "Drink" });
            _mockProducts.Add(new ProductViewModel { id = 2, name = "Name Test2", description = "Description2", price = 2.00M, category = "Drink" });
            _mockProducts.Add(new ProductViewModel { id = 3, name = "Name Test3", description = "Description3", price = 3.00M, category = "Drink" });
            _mockProducts.Add(new ProductViewModel { id = 4, name = "Name Test4", description = "Description4", price = 4.00M, category = "Food" });
            _mockProducts.Add(new ProductViewModel { id = 5, name = "Name Test5", description = "Description5", price = 5.00M, category = "Food" });
            _mockProducts.Add(new ProductViewModel { id = 6, name = "Name Test6", description = "Description6", price = 6.00M, category = "Food" });
        }

        public IEnumerable<ProductViewModel> GetMockProducts()
        {
            return _mockProducts;
        }
    }
}