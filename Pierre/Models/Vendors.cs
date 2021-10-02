using System.Collections.Generic; 

namespace PierreTracker.Models
{
	public class Vendor
	{
		private static List<Vendor> _instances = new List<Vendor> {};
		public string VendorName { get; set; }
		public string Description {get; set; }
		public int Id { get; }
		public List<Order> Orders {get; set; }
		
		public Vendor(string vendorName, string description)
		{
			VendorName = vendorName;
			Description = description;
			_instances.Add(this);
			Id = _instances.Count;
			Items = new List<Order>{};
		}

		public static List<Vendor> GetAll()
		{
			return _instances;
		}
	}
}