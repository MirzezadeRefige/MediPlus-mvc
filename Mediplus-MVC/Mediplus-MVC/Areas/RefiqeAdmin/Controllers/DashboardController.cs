using Microsoft.AspNetCore.Mvc;

namespace Mediplus_MVC.Areas.RefiqeAdmin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
