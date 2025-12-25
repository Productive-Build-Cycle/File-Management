using System.ComponentModel.DataAnnotations;
using FMS.API.Entities.Common;

namespace FMS.API.Entities;

public class FileObject : BaseEntity
{
    [Required]
    [MaxLength(512)]
    public string OriginalFileName { get; set; } = string.Empty;
    [Required]
    [MaxLength(512)]
    public string StoredFileName { get;  set; } = string.Empty;

    
    public string ContentType { get;  set; } = string.Empty;
    public long SizeInBytes { get;  set; } 

    public string BucketName { get;  set; } = string.Empty;
    public string StoragePath { get;  set; } = string.Empty;
}