namespace Ecommerce.Shared.Dtos;

public class CreateProductRequest
{
    // string Name,
    // decimal Price,
    // int Stock,
    // string Description
    
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
    