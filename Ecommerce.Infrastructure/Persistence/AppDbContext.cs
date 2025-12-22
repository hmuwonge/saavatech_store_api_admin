using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Persistence;

public class AppDbContext: DbContext
{
    public DbSet<Product> Products => Set<Product>();
}