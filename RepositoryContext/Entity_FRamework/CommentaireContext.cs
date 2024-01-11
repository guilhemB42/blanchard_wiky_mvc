using Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryContext.Entity_FRamework
{
    public class CommentaireContext : DbContext
    {
        public CommentaireContext(DbContextOptions<CommentaireContext> dbContextOptions): base(dbContextOptions) { }
        public DbSet<Commentaire> Commentaires { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Commentaire> commentaires = new() { 
                new Commentaire { Id = 1, Auteur="Eve", DateCreation=DateTime.Now, Contenu="Non c'est faux",  ArticleId = 1 },
            };
            base.OnModelCreating(modelBuilder);
        }

    }
}
