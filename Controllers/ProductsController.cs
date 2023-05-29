
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using products_app.Models;
using products_app.Services;

namespace products_app.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly ILogger<ProductsController> _logger;
    private readonly IProductService _productService;


    public ProductsController(ILogger<ProductsController> logger, IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("Get All Products");
        return Ok(_productService.GetAll());
    }

    [HttpGet("{id}")]
    public IActionResult GetId(Guid id)
    {
        _logger.LogInformation("Get Product by Id");
        return _productService.GetById(id) is null ? NotFound() : Ok(_productService.GetById(id));
    }

    [HttpPost]
    [Authorize]
    public IActionResult Post([FromBody] Product product)
    {
        _productService.Create(product);
        _logger.LogInformation("Created Product");
        return Created("api/[controller]", null);
    }

    [HttpPut("{id}")]
    [Authorize]
    public IActionResult Put(Guid id, [FromBody] Product product)
    {
        _productService.Update(id, product);
        _logger.LogInformation("Updated Product");
        return NoContent();
    }

    [HttpDelete("{id}")]
    [Authorize]
    public IActionResult Delete(Guid id)
    {
        _productService.Delete(id);
        _logger.LogInformation("Deleted Product");
        return NoContent();
    }
    
}
