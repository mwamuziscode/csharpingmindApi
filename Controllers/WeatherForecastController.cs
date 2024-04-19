using Microsoft.AspNetCore.Mvc;


namespace csharpingmindApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public string GetUser()
    {
        return "Hello World";
    }
}
