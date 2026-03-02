using Example.Core.Services;
using Example.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Example.Core.Controllers;

[ApiController]
[Tags("Users")]
[Route("api/[controller]s")]
public class UserController(ILogger<UserController> logger, IUserService service) : ControllerBase
{
    [EndpointSummary("Get user by username")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpGet("{username}")]
    public IActionResult GetUserByUsername(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            return StatusCode(StatusCodes.Status422UnprocessableEntity,
                "The username must not be empty nor consist only of whitespace characters.");
        }
        
        var response = service.GetUserByUsername(username);
        
        return response is not null ? Ok(response) : NotFound();
    }
}
