using Entities;
using Microsoft.EntityFrameworkCore;

namespace RepositoryContext.Entity_FRamework
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Article> articles = new() { 
            new Article { Id = 1, Theme="Lorem Ipsum", Auteur="Alice", Contenu="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer eget laoreet felis, fermentum porta metus. Suspendisse a dapibus ante. Donec ex purus, sagittis dignissim elit sed, vehicula iaculis lacus. Praesent pretium porta felis. In porttitor leo metus, a tristique tortor convallis eu. Nam luctus lacus eget commodo lobortis. Vestibulum at fermentum tortor, ut volutpat arcu.\r\n\r\nPraesent dictum quam sit amet rutrum consectetur. Curabitur quam quam, mollis ac luctus eu, laoreet vel nunc. Suspendisse vel elit odio. Aenean pharetra sed nisi ut mollis. Fusce eu nisl feugiat, eleifend nisi et, rutrum nunc. Nunc volutpat ante at ligula condimentum blandit. Morbi dapibus, nunc id suscipit mattis, mauris felis blandit lacus, ac tincidunt risus ipsum id nunc. In posuere leo id lectus laoreet elementum. ", DateCreation=DateTime.Now, DateModification=DateTime.Now},
            new Article { Id = 2, Theme="Situation des scribes", Auteur="Otis", Contenu="Vous savez, moi je ne crois pas qu’il y ait de bonne ou de mauvaise situation. Moi, si je devais résumer ma vie aujourd’hui avec vous, je dirais que c’est d’abord des rencontres. Des gens qui m’ont tendu la main, peut-être à un moment où je ne pouvais pas, où j’étais seul chez moi. Et c’est assez curieux de se dire que les hasards, les rencontres forgent une destinée… Parce que quand on a le goût de la chose, quand on a le goût de la chose bien faite, le beau geste, parfois on ne trouve pas l’interlocuteur en face je dirais, le miroir qui vous aide à avancer. Alors ça n’est pas mon cas, comme je disais là, puisque moi au contraire, j’ai pu : et je dis merci à la vie, je lui dis merci, je chante la vie, je danse la vie… je ne suis qu’amour ! Et finalement, quand beaucoup de gens aujourd’hui me disent « Mais comment fais-tu pour avoir cette humanité ? », et bien je leur réponds très simplement, je leur dis que c’est ce goût de l’amour ce goût donc qui m’a poussé aujourd’hui à entreprendre une construction mécanique, mais demain qui sait ? Peut-être simplement à me mettre au service de la communauté, à faire le don, le don de soi…", DateCreation=DateTime.Now.AddDays(-5), DateModification=DateTime.Now.AddDays(-2)},
            new Article { Id = 3, Theme="WQT", Auteur="Criquette", Contenu="Le WQT est un animal aquatique nocturne", DateCreation=DateTime.Now.AddMonths(-2), DateModification=DateTime.Now.AddDays(-18)}
            };
            List<Commentaire> commentaires = new() {
                new Commentaire { Id = 1, Auteur="Bob", DateCreation=DateTime.Now, DateModification = DateTime.Now, Contenu="Lorem lorem",  ArticleId = 1 },
                new Commentaire { Id = 2, Auteur="Asterix", DateCreation=DateTime.Now, DateModification = DateTime.Now, Contenu="C'est une autre culture",  ArticleId = 2 },
                new Commentaire { Id = 3, Auteur="Brett", DateCreation=DateTime.Now, DateModification=DateTime.Now, Contenu="Je vous crois", ArticleId=3}
            };
            modelBuilder.Entity<Article>().HasData(articles);
            modelBuilder.Entity<Commentaire>().HasData(commentaires);
            base.OnModelCreating(modelBuilder);
        }
    }
}
