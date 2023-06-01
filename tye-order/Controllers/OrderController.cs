using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace tye_order.Controllers;

[ApiController]
[Route("order")]
public class OrderController : ControllerBase
{
    [HttpGet]
    public async Task<string> Get()
    {
        return "order-service";
    }

    [HttpGet("call-product")]
    public async Task<Product> CallProductService()
    {
        using var client = new DaprClientBuilder().Build();
        var product = await client.InvokeMethodAsync<Product>(HttpMethod.Get, "tye-product", "api/Product/Product");
        var customer = await client.InvokeMethodAsync<List<WeatherForecast>>(HttpMethod.Get, "tye-customer", "WeatherForecast");
        return product;
    }

    public record Product {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }

      public record Customer {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }

    public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}
}
