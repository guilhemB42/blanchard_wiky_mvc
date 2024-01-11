using Entities;
using IRepositories;
using Microsoft.EntityFrameworkCore;
using RepositoryContext.Entity_FRamework;

namespace RepositoryContext.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        Context articleContext;
        public ArticleRepository(Context context) 
        { 
            articleContext = context;
        }
        public async Task<Article> CreateAsync(Article article)
        {
            articleContext.Articles.Add(article);
            await articleContext.SaveChangesAsync();
            return article;
        }

        public Task<Article> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article>> GetAllAsync()
        {
            return await articleContext.Articles.ToListAsync();
        }

        public async Task<Article> GetByIdAsync(int id)
        {
            return await articleContext.Articles.FindAsync(id);
        }

        public Task<Article> UpdateAsync(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
