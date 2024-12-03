using Microsoft.AspNetCore.Mvc;

namespace Mediplus_MVC.Controllers.Home
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
