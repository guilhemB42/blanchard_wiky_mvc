using IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace blanchard_wiky_mvc.Controllers
{
    public class SearchController : Controller
    {
        IArticleBusiness articleBusiness;

        public SearchController(IArticleBusiness IarticleBusiness) { 
            articleBusiness = IarticleBusiness;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Resultat() {
            return View(await articleBusiness.GetAllAsync());
        }

    }
}
