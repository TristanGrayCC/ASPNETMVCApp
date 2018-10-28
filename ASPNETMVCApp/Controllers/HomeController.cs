using ASPNETMVCApp.Models;
using ASPNETMVCApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNETMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRespository;

        public HomeController(IPieRepository pieRepository)
        {
            pieRespository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var pies = pieRespository.GetAllPies().OrderBy(x => x.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethany's Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}