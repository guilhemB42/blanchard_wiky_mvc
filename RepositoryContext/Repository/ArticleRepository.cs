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
            return await articleContext.Articles.Include(a => a.Comments).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<bool> IsUniqueAsync(string theme)
        {
            return await articleContext.Articles.AnyAsync(a=> a.Theme == theme);
        }

        public Task<Article> UpdateAsync(Article article)
        {
            throw new NotImplementedException();
        }
    }
}
