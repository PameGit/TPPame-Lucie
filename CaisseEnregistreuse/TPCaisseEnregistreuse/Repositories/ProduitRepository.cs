using System.Linq.Expressions;
using TPCaisseEnregistreuse.Data;
using TPCaisseEnregistreuse.Models;

namespace TPCaisseEnregistreuse.Repositories
{
    public class ProduitRepository : IRepository<Produit>
    {
        private ApplicationDbContext _context { get; }
        public ProduitRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public bool Add(Produit produit)
        {
            var addedObj = _context.Produits.Add(produit);
            _context.SaveChanges();
            return addedObj.Entity.Id > 0;
        }

        public Produit? Get(Expression<Func<Produit, bool>> predicate)
        {
            return _context.Produits.FirstOrDefault(predicate);
        }

        public Produit? GetById(int id)
        {
            return _context.Produits.Find(id);
        }

        public List<Produit> GetAll()
        {
            return _context.Produits.ToList();
        }

        public List<Produit> GetAll(Expression<Func<Produit, bool>> predicate)
        {
            return _context.Produits.Where(predicate).ToList();
        }

        public bool Update(Produit produit)
        {
            var produitFromDb = GetById(produit.Id);

            if (produitFromDb == null)
                return false;

            if (produitFromDb.ImageURL != produit.ImageURL)
                produitFromDb.ImageURL = produit.ImageURL;
            if (produitFromDb.Nom != produit.Nom)
                produitFromDb.Nom = produit.Nom;
            if (produitFromDb.Description != produit.Description)
                produitFromDb.Description = produit.Description;
            if (produitFromDb.Prix != produit.Prix)
                produitFromDb.Prix = produit.Prix;
            if (produitFromDb.Stock != produit.Stock)
                produitFromDb.Stock = produit.Stock;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id) 
        { 
            var produit = GetById(id);
            if (produit == null) return false;
            _context.Produits.Remove(produit);
            return _context.SaveChanges() > 0;
        }
    }
}
