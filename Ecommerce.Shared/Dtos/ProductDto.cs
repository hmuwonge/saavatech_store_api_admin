namespace Ecommerce.Shared.Dtos;

public record ProductDto(
    Guid Id,
    string Name,
    string Description,
    decimal Price,
    int Stock
    );