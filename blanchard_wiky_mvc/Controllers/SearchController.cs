using Entities;
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
        public async Task<IActionResult> Resultat(SearchRequest search) {
            List<Article> articles = await articleBusiness.GetAllAsync();
            search.Articles = articles;
            return View(search);
        }

    }
}
