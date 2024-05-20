using KarmaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace KarmaShop.DAL
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> dbContext):base(dbContext) { }
        
       public DbSet<Blog> Blogs { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Post> Posts { get; set; }

        public DbSet<Blogpost> Blogsposts { get; set; }
    }
}
