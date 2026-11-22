using Microsoft.AspNetCore.Mvc;

namespace AppLoadBalancer.Server1.Controllers;

[ApiController]
[Route("[controller]")]
public class ServerController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public ServerController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    [Route("")]
    [Route("/")]
    public IActionResult Get()
    {
        var serverName = _configuration["SERVER_NAME"] ?? "Servidor 1";
        var hostName = Environment.MachineName;
        return Ok($"Requisição {serverName} (Container Host: {hostName})");
    }
}
