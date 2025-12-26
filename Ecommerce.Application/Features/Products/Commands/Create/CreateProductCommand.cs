using Ecommerce.Application.Wrappers;
using Ecommerce.Shared.Dtos;
using MediatR;

namespace Ecommerce.Application.Features.Products.Commands.Create;

public class CreateProductCommand:IRequest<IResponseWrapper>
{
    public CreateProductRequest CreateProduct {get; set;}
}

