using KarmaShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace KarmaShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1,Name="Adidas",Price=200,DiscountPrice=150,Path="p1.jpg"},
                new Product { Id = 2,Name="Adidas2",Price=150,DiscountPrice=120,Path="p2.jpg"},
				new Product { Id = 3,Name="Adidas3",Price=400,DiscountPrice=200,Path="p3.jpg"},
				new Product { Id = 4,Name="Adidas4",Price=300,DiscountPrice=120,Path="p4.jpg"},
				new Product { Id = 5,Name="Adidas5",Price=130,DiscountPrice=90,Path="p5.jpg"},
				new Product { Id = 6,Name="Adidas6",Price=180,DiscountPrice=120,Path="p6.jpg"},

			};
            return View(products);
        }
    }
}
