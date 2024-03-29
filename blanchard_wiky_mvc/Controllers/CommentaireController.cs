﻿using Entities;
using IBusiness;
using Microsoft.AspNetCore.Mvc;

namespace blanchard_wiky_mvc.Controllers
{
    public class CommentaireController : Controller
    {
        ICommentaireBusiness commentaireBusiness;
        public CommentaireController(ICommentaireBusiness IcommentaireBusiness) {
            commentaireBusiness = IcommentaireBusiness;
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int Id)
        {
            return View(await commentaireBusiness.GetByIdAsync(Id));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Commentaire commentaire)
        {
            if (!ModelState.IsValid )
            {
                return View(commentaire);
            }
            else
            {

                commentaire = await commentaireBusiness.CreateAsync(commentaire);
                return RedirectToAction("Detail", "Article", new { Id = commentaire.ArticleId });
            }

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Commentaire commentaire = await commentaireBusiness.GetByIdAsync(id);
            return View(commentaire);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Commentaire commentaire)
        {
            commentaire = await commentaireBusiness.UpdateAsync(commentaire);
            return RedirectToAction("Detail","Article",new { Id = commentaire.ArticleId });
        }
        public async Task<IActionResult> Delete(int id)
        {
            Commentaire commentaire = await commentaireBusiness.GetByIdAsync(id);
            Article articleOfCommentaire = commentaire.Article;
            await commentaireBusiness.DeleteByIdAsync(id);
            return RedirectToAction("Detail","Article",new { Id = articleOfCommentaire.Id});
        }


    }
}
