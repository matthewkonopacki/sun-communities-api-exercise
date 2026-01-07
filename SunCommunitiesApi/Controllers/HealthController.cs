using Microsoft.AspNetCore.Mvc;
using SunCommunitiesApi.Models;

namespace SunCommunitiesApi.Controllers;

[ApiController]
[Route("/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet(Name = "GetHealth")]
    public IActionResult Get()
    {
        return Ok(new StatusResponse("ok"));
    }
};
