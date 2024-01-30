//DbContext is from EntityFrameworkCore
//It contain a virtual method for communicate or open connection
//to the database
using Microsoft.EntityFrameworkCore;
using MySqliteTutorial;

class Northwind : DbContext 
{
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<Supplier> Suppliers { get; set; }
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("FileName=./Northwind.db");
		//optionsBuilder.UseSqlie("Data Source=./Northwind.db")
	}
}