using EFDatabase;

class MainProgram
{
	static void Main() 
	{
		Northwind db = new Northwind();
		Console.WriteLine($"Name: {db.Database}");
		Console.WriteLine($"Database: {db.Database.ProviderName}");
	}
}