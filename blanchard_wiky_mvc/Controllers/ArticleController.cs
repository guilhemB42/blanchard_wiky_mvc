using IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace blanchard_wiky_mvc.Controllers
{
    public class ArticleController : Controller
    {
        IArticleRepository articleRepository;
        public ArticleController(IArticleRepository IarticleRepository) { 
            articleRepository = IarticleRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View(await articleRepository.GetAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJson() { 
            return PartialView("_displayArticles", await articleRepository.GetAllAsync());
        }
    }
}
