using System.Linq.Expressions;
using TPCaisseEnregistreuse.Data;
using TPCaisseEnregistreuse.Models;

namespace TPCaisseEnregistreuse.Repositories
{
    public class CategorieRepository : IRepository<Categorie>
    {
        private ApplicationDbContext _context { get; }
        public CategorieRepository(ApplicationDbContext context) 
        {  
            _context = context; 
        }
        public bool Add(Categorie categorie)
        {
            var addedObj = _context.Categories.Add(categorie);
            _context.SaveChanges();
            return addedObj.Entity.Id > 0;
        }

        public Categorie? Get(Expression<Func<Categorie, bool>> predicate)
        {
            return _context.Categories.FirstOrDefault(predicate);
        }

        public Categorie? GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public List<Categorie> GetAll()
        {
            return _context.Categories.ToList();
        }

        public List<Categorie> GetAll(Expression<Func<Categorie, bool>> predicate)
        {
            return _context.Categories.Where(predicate).ToList();
        }

        public bool Update(Categorie categorie)
        {
            var categorieFromDb = GetById(categorie.Id);

            if (categorieFromDb == null)
                return false;
            if (categorieFromDb.Nom != categorie.Nom)
                categorieFromDb.Nom = categorie.Nom;

            return _context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var categorie = GetById(id);
            if (categorie == null) return false;
            _context.Categories.Remove(categorie);
            return _context.SaveChanges() > 0;
        }
    }
}
