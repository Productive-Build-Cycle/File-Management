namespace FMS.API.DTOs;

public class FileUploadResult
{
    public int Id { get; init; }
    public string OriginalFileName { get; init; } = string.Empty!;
    public string ContentType { get; init; } = string.Empty!;
    public long SizeInBytes { get; init; }
    public string Url { get; init; } = string.Empty;
}