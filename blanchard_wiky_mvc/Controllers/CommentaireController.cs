using Microsoft.AspNetCore.Mvc;

namespace blanchard_wiky_mvc.Controllers
{
    public class CommentaireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
