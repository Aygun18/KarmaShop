using KarmaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace KarmaShop.DAL
{
	public class AppDbContext:DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> dbContext):base(dbContext) { }
        
        DbSet<Blog> Blogs { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Post> Posts { get; set; }
    }
}
