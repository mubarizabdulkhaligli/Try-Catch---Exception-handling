using System;
namespace task1
{
	internal class ProductNotFoundException:Exception
	{
		public ProductNotFoundException():base("The product number you were looking for was not found")
		{
		}
	}
}

