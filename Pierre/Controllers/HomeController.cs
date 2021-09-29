using Microsoft.AspNetCore.Mvc;

namespace PierreTracker.Controllers
{
	public class HomeController : Controller
	{

		[Route("/")]
		public ActionResult Welcome() { return View();}

	}
}