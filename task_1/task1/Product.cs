using System;
namespace task1
{
	internal class Product
	{
		public readonly int No;
		public string Category;
		public double Price;

		private static int _totalCount;

		 public Product()
		{
			_totalCount++;
			No = _totalCount;
		}
	}
}

