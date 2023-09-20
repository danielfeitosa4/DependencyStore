namespace DependencyStore.Models;

public class Customer
{
    public Customer(string id, string email, string name)
    {
        Id = id;
        Email = email;
        Name = name;
    }

    public string Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}