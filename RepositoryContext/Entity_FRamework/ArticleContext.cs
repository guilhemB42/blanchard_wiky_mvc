using Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryContext.Entity_FRamework
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Article> Articles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Article> articles = new() { 
            new Article { Id = 1, Theme="Faux Texte", Auteur="Alice", Contenu="Lorem Ipsum", DateCreation=DateTime.Now},
            new Article { Id = 2, Theme="Montpellier", Auteur="Bob", Contenu="Très belle ville", DateCreation=DateTime.Now.AddDays(-5)},
            new Article { Id = 3, Theme="Canard", Auteur="Charlie", Contenu="Coin coin", DateCreation=DateTime.Now.AddMonths(-2)}
            };
            modelBuilder.Entity<Article>().HasData(articles);
            base.OnModelCreating(modelBuilder);
        }
    }
}
