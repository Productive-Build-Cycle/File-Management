using Microsoft.AspNetCore.Mvc;

namespace FMS.API.Controller;

[ApiController]
[Route("api/[controller]")]
public class FileController :ControllerBase
{
    /// <summary>
    /// Upload a new file (metadata only - storage not implemented yet
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    public IActionResult UploadFile()
    {
        return Ok(new
            {
                Message = "File uploaded successfully",
                At = DateTime.UtcNow
            });
    }
    
}