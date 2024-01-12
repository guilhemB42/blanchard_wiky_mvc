using Entities;
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
        public async Task<IActionResult> GetAllJson()
        { 
            return PartialView("_displayArticles", await articleRepository.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int Id)
        { 
            return View(await articleRepository.GetByIdAsync(Id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<ActionResult> CheckUniqueTheme(string theme)
        {
            bool res = await articleRepository.IsUniqueAsync(theme);
            return Json(!res);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Article article) {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Name", "ERROR MODEL STATE");
                return View(article);
            }
            else { 
                article = await articleRepository.CreateAsync(article);
                return RedirectToAction("Detail", new { Id = article.Id });
            }

        }
    }
}
