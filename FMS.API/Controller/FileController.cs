using FMS.API.DTOs;
using FMS.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS.API.Controller;

[ApiController]
[Route("api/[controller]")]
public class FileController(
    IFileObjectService _file
    ) :ControllerBase
{
    
    private readonly IFileObjectService _file;
    /// <summary>
    /// Upload a new file (metadata only - storage not implemented yet
    /// </summary>
    /// <returns></returns>
    [HttpPost]
    //add request size limit
    public async  Task<ActionResult<FileUploadResult>> UploadFile(
        [FromForm] FileUploadRequest request,
        CancellationToken ct 
        )
    {
        if(request.File.Length == 0) return BadRequest("No file uploaded");
        var result = await _file.UploadFileAsync(request, ct);
        return Ok(result);
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
    public async Task<ActionResult<IReadOnlyList<FileObjectDto>>> GetFiles(CancellationToken ct = default)
    {
        var result = await _file.GetAllFilesAsync(ct);
        if(result.Count == 0) return NotFound("No files found");
        return Ok(result);
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