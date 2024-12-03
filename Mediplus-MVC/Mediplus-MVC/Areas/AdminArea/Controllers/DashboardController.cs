using Mediplus_DAL.Contexts;
using Mediplus_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mediplus_MVC.Areas.AdminArea.Controllers
{
    public class DashboardController : Controller
    {
        private readonly MediplusDbContext _context;

        public DashboardController(MediplusDbContext context)
        {
            _context= context;  
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            List<SliderItem> sliderItems = _context.SliderItems.ToList();
            return View(sliderItems);
        }
    }
}
