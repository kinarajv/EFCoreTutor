using Microsoft.EntityFrameworkCore;
using MySqliteTutorial;

class Program
{
	static void Main() 
	{
		//For Dispose purpose
		//Open connection to the Database
		using(Northwind db = new()) 
		{
			//Check Database connection is valid or not
			Console.WriteLine(db.Database.CanConnect());

			//For view all Category
			//Include for Eager Loading
			List<Category> categories = db.Categories.Include(c => c.Products).ToList();
			foreach(var c in categories) 
			{
				Console.WriteLine($"{c.CategoryId} : {c.CategoryName}");
				Console.WriteLine(c.Products.Count());
				foreach(var p in c.Products) 
				{
					Console.WriteLine($"	{p.ProductId} : {p.ProductName}");
				}
			}
		}
	}
}
//DbContext is from EntityFrameworkCore
//It contain a virtual method for communicate or open connection
//to the database
class Northwind : DbContext 
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("FileName=./Northwind.db");
		//optionsBuilder.UseSqlie("Data Source=./Northwind.db")
	}
}