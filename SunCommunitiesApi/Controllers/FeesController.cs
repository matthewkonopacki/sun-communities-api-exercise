using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SunCommunitiesApi.Interfaces;
using SunCommunitiesApi.Models;

namespace SunCommunitiesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FeesController : ControllerBase
{
    private readonly IFeeCalculator _feeCalculator;
    public FeesController(IFeeCalculator feeCalculator)
    {
        _feeCalculator = feeCalculator;
    }

    [HttpGet("estimate")]
    public IActionResult Get([BindRequired] decimal amount, bool preferred = false)
    {
        return Ok(_feeCalculator.Calculate(amount, preferred));
    }
};
