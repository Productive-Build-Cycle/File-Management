using System.ComponentModel.DataAnnotations;

namespace FMS.API.DTOs;

public record FileUploadRequest
{
    [Required]
    public IFormFile File { get; init; } = null!;
}