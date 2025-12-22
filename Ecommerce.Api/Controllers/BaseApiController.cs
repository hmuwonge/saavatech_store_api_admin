using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.Controllers;

public class BaseApiController:ControllerBase
{
    private ISender _sender = null!;
    public ISender Sender => _sender ??= HttpContext.RequestServices.GetService<ISender>();
}