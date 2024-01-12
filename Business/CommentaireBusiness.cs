using Entities;
using IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business
{
    internal class CommentaireBusiness : ICommentaireBusiness
    {
        public Task<Commentaire> CreateAsync(Commentaire commentaire)
        {
            throw new NotImplementedException();
        }

        public Task<Commentaire> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Commentaire>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Commentaire> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Commentaire> UpdateAsync(Commentaire commentaire)
        {
            throw new NotImplementedException();
        }
    }
}
