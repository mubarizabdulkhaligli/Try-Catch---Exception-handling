using System;
namespace task1
{
	internal class Store
	{

		public Product[] Products = new Product[0];

		public void AddProduct(Product product)
		{
			Array.Resize(ref Products, Products.Length + 1);

			Products[Products.Length - 1] = product;
		}

		public bool HasProductByNo(int number)
		{
			foreach (var product in Products)
			{
				if (product.No == number)
					return true;
			}
			return false;
		}

		public Product GetProductByNo(int num)
		{
			if (HasProductByNo(num))
				return Products[num - 1];
			else throw new ProductNotFoundException();
		}
		
	}
}
