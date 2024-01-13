using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities
{
    public class Commentaire
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)] 
        public string Auteur { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        [StringLength(100)]
        public string Contenu { get; set; }
        [ForeignKey("Article")]
        public int ArticleId { get; set; }
        public Article? Article { get; set; }


    }
}
