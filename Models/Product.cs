namespace KarmaShop.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public decimal DiscountPrice { get; set; }
		public string Path { get; set;}
	}
}
