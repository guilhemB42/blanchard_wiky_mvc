using blanchard_wiky_mvc.Models;
using Entities;
using IBusiness;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace blanchard_wiky_mvc.Controllers
{
    public class HomeController : Controller
    {
        IArticleBusiness articleBusiness;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IArticleBusiness IarticleBusiness)
        {
            articleBusiness = IarticleBusiness;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Article> articles = await articleBusiness.GetAllAsync();
            Article articleLePlusRecent = articles.OrderByDescending(a => a.DateModification).First();
            return View(articleLePlusRecent);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
