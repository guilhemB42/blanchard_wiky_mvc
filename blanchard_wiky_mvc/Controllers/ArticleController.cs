using Entities;
using IBusiness;
using IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace blanchard_wiky_mvc.Controllers
{
    public class ArticleController : Controller
    {
        IBusiness.IArticleBusiness articleBusiness;
        public ArticleController(IArticleBusiness IarticleBusiness) { 
            articleBusiness = IarticleBusiness;
        }
        public async Task<IActionResult> Index()
        {
            return View(await articleBusiness.GetAllAsync());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllJson()
        { 
            return PartialView("_displayArticles", await articleBusiness.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int Id)
        { 
            return View(await articleBusiness.GetByIdAsync(Id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public async Task<ActionResult> CheckUniqueTheme(string theme)
        {
            bool res = await articleBusiness.IsUniqueAsync(theme);
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
                article = await articleBusiness.CreateAsync(article);
                article.DateCreation=DateTime.Now;
                article.DateModification=DateTime.Now;
                return RedirectToAction("Detail", new { Id = article.Id });
            }

        }
    }
}
