using KarmaShop.DAL;
using KarmaShop.Models;
using KarmaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace KarmaShop.Controllers
{
	public class BlogController : Controller
	{
        public AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
		{

			var blogs=_db.Blogs.ToList();
			var posts=_db.Posts.ToList();

			var blogpost=_db.Blogsposts.ToList();

			BlogVM blogVM = new BlogVM
			{
				Blogs = blogs,
				Posts = posts,
				Blogsposts=blogpost
			};
			return View(blogVM);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]

		public IActionResult Create(Blogpost blogpost)
		{
			_db.Blogsposts.Add(blogpost);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
