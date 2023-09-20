namespace DependencyStore.Models;

public class Product
{
    public Product(string id, decimal price, string? name)
    {
        Id = id;
        Price = price;
        Name = name;
    }

    public string Id { get; set; }
    public decimal Price { get; set; }
    public string? Name { get; set; }
}