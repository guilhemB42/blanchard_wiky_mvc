using Entities;

namespace IRepositories
{
    public interface ICommentaireRepository
    {
        Task<List<Commentaire>> GetAllAsync();
        Task<Commentaire> GetByIdAsync(int id);
        Task<Commentaire> CreateAsync(Article article);
        Task<Commentaire> UpdateAsync(Article article);
        Task<Commentaire> DeleteByIdAsync();
    }
}
