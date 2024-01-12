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
            return await commentaireContext.Commentaires.Include(c=>c.Article).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Commentaire> UpdateAsync(Commentaire commentaire)
        {
            Commentaire commentaireToEdit = commentaireContext.Commentaires.Find(commentaire.Id);
            commentaireToEdit.Contenu = commentaire.Contenu;
            commentaireToEdit.DateModification = commentaire.DateModification;
            await commentaireContext.SaveChangesAsync();
            return commentaire;
        }
    }
}
