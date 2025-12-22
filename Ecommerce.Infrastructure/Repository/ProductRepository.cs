using Ecommerce.Application.Abstractions;
using Ecommerce.Application.Abstractions.Repositories;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure.Repository;

public class ProductRepository: IProductRepository
{
    private readonly AppDbContext _context;
    public async Task AddAsync(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task<Product> FindByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}