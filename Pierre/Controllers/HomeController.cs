using Microsoft.AspNetCore.Mvc;
using PierreTracker.Models;

namespace PierreTracker.Controllers
{
	public class HomeController : Controller
	{

		[Route("/")]
		public ActionResult Welcome() { return View();}

	}
}