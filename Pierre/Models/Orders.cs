using System.Collections.Generic;

namespace PierreTracker.Models
{
	public class Order
	{
		public string Product { get; set; }
		public string ProductDescription { get; set; }
		public int Price { get; set; }
		public string Date { get; set; }
		public int Id { get; }
		private static List<Order> _instances = new List<Order> {};

		public Order(string product, string productDescription, int price, string date)
		{
			Product = product;
			ProductDescription = productDescription;
			Price = price;
			Date = date;
			_instances.Add(this);
			Id = _instances.Count;
		}

		public static void ClearAll()
		{
			_instances.Clear();
		}

		public static List<Order> GetAll()
		{
			return _instances;
		}

	}
}