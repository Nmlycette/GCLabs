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
		_mockProducts.Add(new ProductViewModel { ID = 1, name = 'Hot Cocoa', description = 'Hot cocoa with marshmallows and whipped cream', price = 2.50, category = 'drink'});
		_mockProducts.Add(new ProductViewModel { ID = 2, name = 'Cappucino', description 'French Vanilla, Chocolate or Caramel flavored cappucino with foamed milk and two shots of espresso', price 3.00, category = 'drink' });
        _mockProducts.Add(new ProductViewModel { ID = 3, name = 'Coffee', description 'Coffee with cream and/or sugar', price 3.00, category = 'drink' });
        _mockProducts.Add(new ProductViewModel { ID = 4, name = 'Muffin', description 'Blueberry, Lemon Poppy, or Chocolate flavored muffin', price 2.00, category = 'food'});
        _mockProducts.Add(new ProductViewModel { ID = 4, name = 'Croissant', description 'Butter or Chocolate croissant', price 2.00, category = 'food' });
        _mockProducts.Add(new ProductViewModel { ID = 4, name = 'Sandwich', description 'Ham and swiss, Tukey and provolone, or Grilled cheese sandwich', price 3.50, category = 'food' });
    }

    public IEnumberable<ProductViewModel> GetMockProducts()
	{
		return _mockProducts;
	}
}
