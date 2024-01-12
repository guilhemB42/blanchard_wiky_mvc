using Entities;
using IBusiness;
using IRepositories;

namespace Business
{
    public class ArticleBusiness : IArticleBusiness
    {
        IArticleRepository _articleRepository { get; }

        public ArticleBusiness(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public Task<Article> CreateAsync(Article article)
        {
            if (article.Auteur.Length > 30) {
                throw new Exception("le nom de l'auteur est trop long");
            }
            article.DateCreation = DateTime.Now;
            article.DateModification = DateTime.Now;
            return _articleRepository.CreateAsync(article);
        }

        public Task DeleteByIdAsync(int id)
        {
            return _articleRepository.DeleteByIdAsync(id);
        }

        public Task<List<Article>> GetAllAsync()
        {
            return _articleRepository.GetAllAsync();
        }

        public Task<Article> GetByIdAsync(int id)
        {
            return _articleRepository.GetByIdAsync(id);
        }

        public Task<bool> IsUniqueAsync(string theme)
        {
            return _articleRepository.IsUniqueAsync(theme);
        }

        public Task<Article> UpdateAsync(Article article)
        {
            return _articleRepository.UpdateAsync(article);
        }
    }
}
