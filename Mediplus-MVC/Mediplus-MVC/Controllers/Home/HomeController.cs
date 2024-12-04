using Mediplus_DAL.Contexts;
using Mediplus_DAL.Models;
using Mediplus_MVC.ViewModels.Service;
using Microsoft.AspNetCore.Mvc;

namespace Mediplus_MVC.Controllers.Home
{
	public class HomeController : Controller
	{

		private readonly MediplusDbContext _context;

		public HomeController(MediplusDbContext context)
		{
			_context = context;
		}


		public IActionResult Index()
		{
			var services = _context.Services.ToList();	
			List<ServiceVM> serv = services.Select(s => new ServiceVM
			{
				Id = s.Id,
				Name = s.Name,
			}).ToList();
			return View(serv);
		}
	}
}
