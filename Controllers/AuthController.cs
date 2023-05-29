using Microsoft.AspNetCore.Mvc;
using products_app.Models;
using products_app.Models.DTO;
using products_app.Services;

namespace products_app.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;

    private readonly IAuthService _authService;

    public AuthController(ILogger<ProductsController> logger, IAuthService authService)
    {
        _logger = logger;
        _authService = authService;
    }

    [HttpPost, Route("signup")]
    public async Task<IActionResult> signUp([FromBody] User user)
    {
        await _authService.Register(user);
        
        _logger.LogInformation("User registed");

        return Ok();

    }

    [HttpPost, Route("signIn")]
    public async Task<IActionResult> signIn([FromBody] UserLoginDto user)
    {
        var token = await _authService.Login(user.Email, user.Password);

        _logger.LogInformation("Token created");

        return token is null ? NotFound() : Ok(new {token});


    }
    
}
