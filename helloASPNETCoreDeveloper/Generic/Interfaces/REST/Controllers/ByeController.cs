﻿using helloASPNETCoreDeveloper.Generic.Interfaces.REST.Resources;
using Microsoft.AspNetCore.Mvc;

namespace helloASPNETCoreDeveloper.Generic.Interfaces.REST.Controllers;

[ApiController]
[Route("[controller]")]
public class ByeController: ControllerBase
{
    [HttpGet("{name}")]
    public ByeResource Bye(string name)
    {
        return new ByeResource(name);
    }
}