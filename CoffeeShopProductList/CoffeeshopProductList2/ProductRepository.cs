using System;

public class ProductRepository
{

	private List<ProductViewModel> _mockProducts;
	
	public ProductRepository()
	{
		CreateMockProductList();
	}

	private void CreateProductList()
	{
		_mockProducts = new List<ProductViewModel>();
		_mockProducts.Add(new ProductViewModel { });
	}

	public IEnumberable<ProductViewModel> GetMockProducts()
	{
		return _mockProducts;
	}
}
