using Entities;
using IBusiness;
using IRepositories;

namespace Business
{
    public class CommentaireBusiness : ICommentaireBusiness
    {
        ICommentaireRepository _commentaireRepository { get; }

        public CommentaireBusiness(ICommentaireRepository commentaireRepository) { 
            _commentaireRepository = commentaireRepository;
        }
        public Task<Commentaire> CreateAsync(Commentaire commentaire)
        {
            if (commentaire.Auteur.Length > 30) {
                throw new Exception("le nom de l'auteur du comm est trop long");
            }
            if (commentaire.Contenu.Length > 100) {
                throw new Exception("le contenu du comm est trop long");
            }
            commentaire.DateCreation = DateTime.Now;
            commentaire.DateModification = DateTime.Now;
            return _commentaireRepository.CreateAsync(commentaire);
        }

        public Task DeleteByIdAsync(int id)
        {
            return _commentaireRepository.DeleteByIdAsync(id);
        }

        public Task<List<Commentaire>> GetAllAsync()
        {
            return _commentaireRepository.GetAllAsync();
        }

        public Task<Commentaire> GetByIdAsync(int id)
        {
            return _commentaireRepository.GetByIdAsync(id);
        }

        public Task<Commentaire> UpdateAsync(Commentaire commentaire)
        {
            commentaire.DateModification = DateTime.Now;
            return _commentaireRepository.UpdateAsync(commentaire);
        }
    }
}
