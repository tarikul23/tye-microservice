using Microsoft.AspNetCore.Mvc;

namespace tye_product.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Product Product()
    {
        Console.WriteLine("product request");
        return new Product{
            Name = "test",
            Date = DateTime.Now
        };
    }

    [HttpGet]
    public Customer Customer()
    {
        Console.WriteLine("customer request");
        return new Customer{
            Name = "tarikul",
            Date = DateTime.Now
        };
    }
}
