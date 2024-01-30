using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySqliteTutorial;

public class Product
{
	[Key]
	public int ProductId { get; set; }
	[Required, StringLength(40)]
	public string ProductName { get; set; } = null!;
	[ForeignKey("Category")]
	public int CategoryId { get; set; }
	public Category Category { get; set; } = null!;
}
