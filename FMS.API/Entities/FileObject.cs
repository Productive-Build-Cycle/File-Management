using System.ComponentModel.DataAnnotations;
using FMS.API.Entities.Common;

namespace FMS.API.Entities;

public class FileObject : BaseEntity
{
    protected FileObject() { }
    public FileObject(
        
        string originalFileName,
        string storedFileName,
        string contentType,
        long size,
        string bucketName)
    {
        if (string.IsNullOrWhiteSpace(originalFileName)) throw new ArgumentNullException(nameof(originalFileName));
        if (string.IsNullOrWhiteSpace(storedFileName)) throw new ArgumentNullException(nameof(storedFileName));
        if (size <= 0) throw new ArgumentException("File size must be greater than zero.", nameof(size));
        if (string.IsNullOrWhiteSpace(bucketName)) throw new ArgumentNullException(nameof(bucketName));
        OriginalFileName = originalFileName;
        StoredFileName = storedFileName;
        ContentType = contentType;
        SizeInBytes = size;
        BucketName = bucketName;
        CreatedAt = DateTime.UtcNow;
        StoragePath = $"{BucketName}/{StoredFileName}";
    }
    [Required]
    [MaxLength(512)]
    public string OriginalFileName { get; private set; } = string.Empty; 

    [Required]
    [MaxLength(512)]
    public string StoredFileName { get; private set; } = string.Empty; 

    [MaxLength(100)]
    public string ContentType { get; private set; } = string.Empty;
    public long SizeInBytes { get; private set; }
    [MaxLength(100)]
    public string BucketName { get; private set; } = string.Empty;
    [MaxLength(1024)]
    public string StoragePath { get; private set; } = string.Empty;
}