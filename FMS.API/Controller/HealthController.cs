using Microsoft.AspNetCore.Mvc;

namespace FMS.API.Controller;

[ApiController]

public class HealthController: ControllerBase
{
    
    /// <summary>
    /// this endpoint is used for health check on docker servicer.
    /// </summary>
    /// <returns></returns>
    [HttpGet("/health")]
    public IActionResult HealthCheck() => Ok();
}