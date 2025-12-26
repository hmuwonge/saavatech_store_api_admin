using Ecommerce.Application.Abstractions;
using Ecommerce.Application.Abstractions.Repositories;
using Ecommerce.Domain.Entities;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure.Repository;

public class ProductRepository: IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<int> AddAsync(Product product)
    {
        _context.Products.Add(product);
        var res = await _context.SaveChangesAsync();
        return res;
    }

    public async Task<Product> FindByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}