using Microsoft.AspNetCore.Mvc;

namespace PierreTracker.Controllers
{
	public class HomeController : Controller
	{
		[Route("/ordertracker")]
		public string OrderTracker() { return "Look at orders here!";}

		[Route("/")]
		public string Welcome() { return "Welcome To Pierre's!";}

	}
}