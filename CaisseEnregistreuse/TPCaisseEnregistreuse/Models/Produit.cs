using System.ComponentModel.DataAnnotations;

namespace TPCaisseEnregistreuse.Models
{
    public class Produit 
    {
        public int Id { get; set; }
        [Required]
        public string? Nom { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double Prix { get; set; }
        [Required]
        public int Stock { get; set; }
        public string? ImageURL { get; set; }
        public int? CategorieId { get; set; }
    }
}
