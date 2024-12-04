using Mediplus_DAL.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Mediplus_MVC.Areas.AdminArea.Controllers;

[Area("Admin")]
public class DashboardController : Controller
{
    private readonly MediplusDbContext _context;

    public DashboardController(MediplusDbContext context)
    {
        _context= context;  
    }
   
    public IActionResult Index()
    {
        //List<SliderItem> sliderItems = _context.SliderItems.ToList();
        //return View(sliderItems);
        return View();  
    }
}
