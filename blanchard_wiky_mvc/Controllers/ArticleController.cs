using Entities;
using IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace blanchard_wiky_mvc.Controllers
{
    public class ArticleController : Controller
    {
        IArticleBusiness articleBusiness;
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
        public async Task<IActionResult> CheckUniqueTheme(string theme)
        {
            bool res = await articleBusiness.IsUniqueAsync(theme);
            return Json(!res);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Article article) {
            if (!ModelState.IsValid || await articleBusiness.IsUniqueAsync(article.Theme))
            {
              return View(article);
            }
            else { 
                article = await articleBusiness.CreateAsync(article);
                return RedirectToAction("Detail", new { Id = article.Id });
            }

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Article article = await articleBusiness.GetByIdAsync(id);
            return View(article);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Article article) { 
            article = await articleBusiness.UpdateAsync(article);
            return RedirectToAction("Detail", new { Id = article.Id });
        }
        public async Task<IActionResult> Delete(int id) { 
            await articleBusiness.DeleteByIdAsync(id);
            return RedirectToAction("Index");
        }
    }
}
