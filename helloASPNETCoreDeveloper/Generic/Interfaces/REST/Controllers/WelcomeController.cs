using Microsoft.AspNetCore.Mvc;

namespace helloASPNETCoreDeveloper.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route(template:"[controller]")]
public class WelcomeController : ControllerBase
{
    
    [HttpGet]
    public string Welcome()
    {
        return "Welcome!";
    }
}