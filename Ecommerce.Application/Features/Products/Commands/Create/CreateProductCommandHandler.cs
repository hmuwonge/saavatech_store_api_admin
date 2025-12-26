using AutoMapper;
using Ecommerce.Application.Abstractions.Repositories;
using Ecommerce.Application.Wrappers;
using Ecommerce.Domain.Entities;

using MediatR;

namespace Ecommerce.Application.Features.Products.Commands.Create;

public class CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    : IRequestHandler<CreateProductCommand, IResponseWrapper>
{
    public async Task<IResponseWrapper> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = mapper.Map<Product>(request.CreateProduct);
        var productId =  await productRepository.AddAsync(product);
        return  await ResponseWrapper<int>.SuccessAsync(productId, "Product created successfully");
    }
}