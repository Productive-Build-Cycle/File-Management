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
            Message = "file by Id found",
        });
    }
    /// <summary>
    /// Get all files list
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public IActionResult GetFiles()
    {
        return Ok(new
        {
            Message = "All files list",
        });
    }
    /// <summary>
    /// Update a file by Id
    /// </summary>
    /// <returns></returns>
    [HttpPatch("id:int")]
    public IActionResult UpdateFile()
    {
        return Ok(new
        {
            Message = "File Updated Successfully",
        });
    }

    /// <summary>
    /// Delete a file by id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete("id:int")]
    public IActionResult DeleteFileById(int id)
    {
        return Ok(new
        {
            Id = id,
            Message = "File Deleted Successfully",
        });
    }
    /// <summary>
    /// Delete a file by range
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public IActionResult DeleteByRange()
    {
        return Ok(new
        {
            Message = "Files Deleted Successfully",
        });
    }
    
}