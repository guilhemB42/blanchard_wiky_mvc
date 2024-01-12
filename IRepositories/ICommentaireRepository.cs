using Entities;

namespace IRepositories
{
    public interface ICommentaireRepository
    {
        Task<List<Commentaire>> GetAllAsync();
        Task<Commentaire> GetByIdAsync(int id);
        Task<Commentaire> CreateAsync(Commentaire commentaire);
        Task<Commentaire> UpdateAsync(Commentaire commentaire);
        Task DeleteByIdAsync(int id);
    }
}
