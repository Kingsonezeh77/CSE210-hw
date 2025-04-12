using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
		// Product Class
	class Product
	{
		private string name;
		private string productId;
		private decimal price;
		private int quantity;

		public Product(string name, string productId, decimal price, int quantity)
		{
			this.name = name;
			this.productId = productId;
			this.price = price;
			this.quantity = quantity;
		}

		public string GetProductName()
		{
			return name;
		}

		public string GetProductId()
		{
			return productId;
		}

		public decimal GetTotalCost()
		{
			return price * quantity;
		}
	}
}