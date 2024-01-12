using Entities;

namespace IBusiness
{
    public interface ICommentaireBusiness
    {
        Task<List<Commentaire>> GetAllAsync();
        Task<Commentaire> GetByIdAsync(int id);
        Task<Commentaire> CreateAsync(Commentaire commentaire);
        Task<Commentaire> UpdateAsync(Commentaire commentaire);
        Task<Commentaire> DeleteByIdAsync(int id);
    }
}
