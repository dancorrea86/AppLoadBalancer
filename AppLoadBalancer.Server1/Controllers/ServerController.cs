using Microsoft.AspNetCore.Mvc;

namespace AppLoadBalancer.Server1.Controllers;

[ApiController]
[Route("[controller]")]
public class ServerController : ControllerBase
{
    [HttpGet]
    [Route("")]
    [Route("/")]
    public IActionResult Get()
    {
        return Ok("Requisição Servidor 1");
    }
}
