using System;
namespace products_app.Models;

public class Product
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public float Price { get; set; }
	public int Stock { get; set; }
	public string Image { get; set; }
	public DateTime CreatedAt { get; set; }
	public DateTime UpdatedAt { get; set; }

}
