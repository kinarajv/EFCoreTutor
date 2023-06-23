using EFCore;
using Microsoft.EntityFrameworkCore;

namespace EFDatabase;

public class Northwind : DbContext
{

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		
		string path = Path.Combine( Environment.CurrentDirectory, "Northwind.db");
		
		string connection = ($"Filename={path}");
		
		Console.WriteLine($"Connection: {connection}");
		optionsBuilder.UseSqlite(connection);
	}
}