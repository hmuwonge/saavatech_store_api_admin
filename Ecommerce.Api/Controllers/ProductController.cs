using Ecommerce.Application.Features.Products.Commands.Create;
using Ecommerce.Shared.Dtos;
using Ecommerce.Shared.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : BaseApiController
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductRequest request)
    {
        Console.WriteLine($"DEBUG: request is null? {request == null}");
        Console.WriteLine($"DEBUG: request {request?.Name}");
        try
        {
            var response = await Sender.Send(
                new CreateProductCommand
                {
                    CreateProduct = request
                });

            if (response.IsSuccessful)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
