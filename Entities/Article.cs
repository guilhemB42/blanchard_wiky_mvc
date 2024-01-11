using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Article
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        [Required]
        [StringLength(30)]
        public string Auteur { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public string Contenu { get; set; }
        public List<Commentaire> Comments { get; set; }
    }
}
