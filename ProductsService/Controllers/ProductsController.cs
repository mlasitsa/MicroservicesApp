using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> Products = new()
    {
        new Product { Id = 1, Name = "Product A", Price = 9.99m },
        new Product { Id = 2, Name = "Product B", Price = 19.99m }
    };

    [HttpGet]
    public IActionResult Get() => Ok(Products);

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.Id = Products.Count + 1;
        Products.Add(product);
        return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
    }
}
