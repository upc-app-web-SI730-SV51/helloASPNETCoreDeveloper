using helloASPNETCoreDeveloper.Generic.Domain.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace helloASPNETCoreDeveloper.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class WelcomeController : ControllerBase
{
    
    [HttpGet]
    public string Welcome()
    {
        return WelcomeBuilder.Builder(null);
    }
    
    [HttpGet("{name}")]
    public string Welcome(string name)
    {
        return WelcomeBuilder.Builder(name);
    }
    
    
}