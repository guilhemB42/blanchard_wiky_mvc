using Entities;

namespace IBusiness
{
    public interface IArticleBusiness
    {
        Task<List<Article>> GetAllAsync();
        Task<Article> GetByIdAsync(int id);
        Task<Article> CreateAsync(Article article);
        Task<Article> UpdateAsync(Article article);
        Task DeleteByIdAsync(int id);
        Task<bool> IsUniqueAsync(string theme);
    }
}
