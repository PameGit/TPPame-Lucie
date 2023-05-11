using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using TPCaisseEnregistreuse.Models;
using static System.Net.WebRequestMethods;

namespace TPCaisseEnregistreuse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cat = new List<Categorie>()
           {
               new Categorie{Id = 1, Nom = "Electromenager"},
               new Categorie{Id = 2, Nom = "Epicerie sucrée"},
               new Categorie{Id = 3, Nom = "Entretien de la maison"}

           };
            modelBuilder.Entity<Categorie>().HasData(cat);

            var produits = new List<Produit>()
            {
               new Produit{Id = 1, Nom = "Balai", Description = "Blanc à frange", Prix = 9.99, Stock = 25, CategorieId = 3, ImageURL = "https://m.media-amazon.com/images/I/41gXsVV+2aL._AC_SY355_.jpg"},
               new Produit{Id = 2, Nom = "Tablette de chocolat", Description="Blanc à la framboise", Prix = 15.50, Stock=8, CategorieId = 2, ImageURL = "https://www.valrhona-ensemble.fr/media/catalog/product/cache/b0b97e8afa64efe2e2cbbf9acc352179/t/a/tablette-ivoire-framboise_1_.jpg"},
               new Produit{Id = 3, Nom = "Cafetiere", Description="Dolce Gusto", Prix = 100, Stock=5, CategorieId = 1, ImageURL = "https://image.darty.com/darty?type=image&source=/market/2020/10/02/15687657_1507_1.jpg&width=267&height=400&quality=90&effects=Pad(CC,FFFFFF)"},
               new Produit{Id = 4, Nom = "Aspirateur", Description="Dyson", Prix = 699.99, Stock=2, CategorieId = 1, ImageURL = "https://dyson-h.assetsadobe2.com/is/image/content/dam/dyson/images/products/primary/419649-01.png?$responsive$&cropPathE=mobile&fit=stretch,1&wid=440"}
           };
            modelBuilder.Entity<Produit>().HasData(produits);
        }
    }
}
