using Sample.Store.Models.Interfaces;
using Sample.Store.Models;

namespace Sample.Store.Models;

public class Product : IDatabasePromise
{
	public int Id { get; set; }

	public Guid ProductIdentifier { get; set; }

	public string? Name { get; set; }

	public ProductCategory Category { get; set; } = new();

	public decimal? Price { get; set; }
}