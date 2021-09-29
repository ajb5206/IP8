using Microsoft.AspNetCore.Mvc;

namespace PierreTracker.Controllers
{
	public class OrderController : Controller
	{
		[Route("/ordertracker")]
		public ActionResult OrderTracker() { return View();}

	}
}