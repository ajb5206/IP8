using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;

namespace PierreTracker.Controllers
{
	public class OrderController : Controller
	{
		[Route("/ordertracker")]
		public ActionResult OrderTracker(string product, string productDescription, int price, string date) 
		{ 
			Order newOrder = new Order();
			newOrder.Product = product;
			newOrder.ProductDescription = productDescription;
			newOrder.Price = price;
			newOrder.Date = date;
			return View(newOrder);
		}
	}
}