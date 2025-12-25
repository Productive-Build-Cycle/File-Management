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
    /// <summary>
    /// Get a file by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet("id:int")]
    public IActionResult GetFileById(int id)
    {
        return Ok(new
        {
            Id = id,
            Message = "Not implemented yet",
        });
    }
    
}