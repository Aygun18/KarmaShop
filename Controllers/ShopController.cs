using KarmaShop.DAL;
using KarmaShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KarmaShop.Controllers
{
	public class ShopController : Controller
	{
		public AppDbContext _db;
        public ShopController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
		{
			
			var products=_db.Products.ToList();
			return View(products);
		}
	}
}
