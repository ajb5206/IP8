using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;

namespace PierreTracker.Controllers
{
	public class OrderController : Controller
	
	{
		[HttpGet("/vendors/{vendorId}/orders/new")]
		public ActionResult New(int vendorId) 
		{
			
		}
		[HttpGet("/vendors/{vendorId}/orders/{orderId}")]
		public ActionResult Show(int vendorId, int orderId)
		{ 
			Order newOrder = new Order("");
			newOrder.Product = product;
			newOrder.ProductDescription = productDescription;
			newOrder.Price = price;
			newOrder.Date = date;
			return View(newOrder); 
		}
	}
}