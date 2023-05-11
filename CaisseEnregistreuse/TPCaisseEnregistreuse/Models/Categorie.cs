using System.ComponentModel.DataAnnotations;

namespace TPCaisseEnregistreuse.Models
{
    public class Categorie
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public List<Produit>? ProduitList { get; set;}
    }
}
