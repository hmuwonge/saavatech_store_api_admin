using Ecommerce.Application.Abstractions;
using Ecommerce.Application.Abstractions.Repositories;
using Ecommerce.Application.Wrappers;
using Ecommerce.Domain.Entities;
using MediatR;

namespace Ecommerce.Application.Features.Products.Create;

public class CreateProductHandler:IRequestHandler<CreateProductCommand, IResponseWrapper>
{
    private readonly IProductRepository _productRepository;
    public CreateProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    public async Task<IResponseWrapper> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = request.CreateProduct.Adapt<Product>();
       var productId =  await _productRepository.AddAsync(product);
        return  await ResponseWrapper<int>.SuccessAsync(productId, "Product created successfully");
    }
}