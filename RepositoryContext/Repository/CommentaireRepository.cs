using Entities;
using IRepositories;
using Microsoft.EntityFrameworkCore;
using RepositoryContext.Entity_FRamework;

namespace RepositoryContext.Repository
{
    public class CommentaireRepository : ICommentaireRepository
    {
        Context commentaireContext;
        public CommentaireRepository(Context context) {
            commentaireContext = context;
        }
        public async Task<Commentaire> CreateAsync(Commentaire commentaire)
        {
            commentaireContext.Commentaires.Add(commentaire);
            await commentaireContext.SaveChangesAsync();

            return commentaire;
        }

        public async Task DeleteByIdAsync(int id)
        {
            Commentaire commentaireToDelete = await commentaireContext.Commentaires.FirstOrDefaultAsync(c => c.Id == id);
            commentaireContext.Commentaires.Remove(commentaireToDelete);
            await commentaireContext.SaveChangesAsync();
        }

        public async Task<List<Commentaire>> GetAllAsync()
        {
            return await commentaireContext.Commentaires.ToListAsync();
        }

        public async Task<Commentaire> GetByIdAsync(int id)
        {
            return await commentaireContext.Commentaires.FindAsync(id);
        }

        public Task<Commentaire> UpdateAsync(Commentaire commentaire)
        {
            throw new NotImplementedException();
        }
    }
}
