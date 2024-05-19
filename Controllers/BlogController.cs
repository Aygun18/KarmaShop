using KarmaShop.Models;
using KarmaShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace KarmaShop.Controllers
{
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			List<Blog> blogs = new List<Blog>
			{
				new Blog{Id=1,Category="Social Life!",Desctiption="Enjoy",Path="cat-post-3.jpg"},
				new Blog{Id=1,Category="Politics!",Desctiption="Politics",Path ="cat-post-2.jpg"},
				new Blog{Id=1,Category="Food!",Desctiption="Food",Path ="cat-post-1.jpg"},
			};

			List<Post> posts = new List<Post>
			{
				new Post{Id=1,Title="Space The Final Frontier!",Path="post1.jpg",Date="03 hours ago"},
				new Post{Id=1,Title="The Amazing Hubble!",Path="post2.jpg",Date="04 hours ago"},
				new Post{Id=1,Title="Astronomy Or Astrology!",Path="post3.jpg",Date="04 hours ago"},

			};

			BlogVM blogVM = new BlogVM
			{
				Blogs = blogs,
				Posts = posts
			};
			return View(blogVM);
		}
	}
}
