using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Abstractions.Repositories;

public interface IProductRepository
{
    Task<int> AddAsync(Product product);
    Task<Product> FindByIdAsync(Guid id);

}