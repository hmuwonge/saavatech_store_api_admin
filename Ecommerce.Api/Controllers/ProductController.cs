using Ecommerce.Application.Features.Products.Create;
using Ecommerce.Shared.Dtos;
using Ecommerce.Shared.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : BaseApiController
{
    private readonly IMediator _mediator;

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        Console.WriteLine($"DEBUG: _mediator is null? {_mediator == null}");
        Console.WriteLine($"DEBUG: request is null? {request == null}");
        try
        {
            var id = await _mediator.Send(
                new CreateProductCommand(request.Name,  request.Price, request.Stock,request.Description));
            return Ok(new ApiResponse<Guid>
            {
                Success = true,
                Data = id
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
    }
    
}