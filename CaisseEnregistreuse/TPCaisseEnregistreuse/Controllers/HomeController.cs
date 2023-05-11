using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TPCaisseEnregistreuse.Models;
using TPCaisseEnregistreuse.Repositories;
using TPCaisseEnregistreuse.Services;

namespace TPCaisseEnregistreuse.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Produit> _db;
        private readonly IRepository<Categorie> _cat;
        private readonly IUploadService _uploadService;

        public HomeController(IRepository<Produit> db, IRepository<Categorie> cat, IUploadService uploadService)
        {
            _db = db;
            _cat = cat;
            _uploadService = uploadService;
        }


        public IActionResult Index()
        {
            var listeProduit = _db.GetAll().ToList();
            return View(listeProduit);
        }

        public IActionResult Categories()
        {
            var listeCategories = _cat.GetAll().ToList();
            return View(listeCategories);

        }

        public IActionResult Details(int id)
        {

            return View();
        }

        public IActionResult FormulaireProduitAjout()
        {
            return View("FormProduit");
        }
        
        public IActionResult FormulaireProduitUpdate(int id)
        {
            var produit = _db.GetById(id);
            return View("FormProduit", produit);
        }

        public IActionResult SubmitProduit(Produit produit, IFormFile image)
        {
            string filePath = _uploadService.Upload(image);
            produit.ImageURL = filePath;

            if (produit.Id == 0)
            {
                _db.Add(produit);
            }
            else
            {
                _db.Update(produit);
            }
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}