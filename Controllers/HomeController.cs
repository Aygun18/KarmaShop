using KarmaShop.DAL;
using KarmaShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace KarmaShop.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var products= _db.Products.ToList();
            return View(products);
        }
    }
}
