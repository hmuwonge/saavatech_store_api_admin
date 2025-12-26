using AutoMapper;
using Ecommerce.Domain.Entities;
using Ecommerce.Shared.Dtos;

namespace Ecommerce.Application.Mappings;

public class ProductProfile:Profile
{
    public ProductProfile()
    {
        CreateMap<CreateProductRequest, Product>();
    }
}