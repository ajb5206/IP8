using System.Collections.Generic;

namespace PierreTracker.Models
{
	public class Order
	{
		public string Product { get; set; }
		public string ProductDescription { get; set; }
		public int Price { get; set; }
		public string Date { get; set; }
		private static List<Item> _instances = new List<Item> {};

		public Item(string product, string productDescription, int price, string date)
		{
			Product = product;
			ProductDescription = productDescription;
			Price = price;
			Date = date;
			_instances.Add(this);
		}

		public static List<Item> GetAll()
		{
			return _instances;
		}

	}
}