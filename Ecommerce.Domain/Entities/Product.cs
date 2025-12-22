namespace Ecommerce.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Description { get; private set; }
    
    private Product() { }

    public Product( string name, decimal price, int stock, string description)
    {
        // if (price <= 0) throw new DomainException("Price must be greater than zero");
        Id = Guid.NewGuid();
        Name = name;
        Price = price;
        Stock = stock;
        Description = description;
    }
}