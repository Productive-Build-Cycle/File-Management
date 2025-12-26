namespace FMS.API.Services.Interfaces;

public interface IStorageService
{
    Task<string> UploadAsync(IFormFile file, string bucketName, CancellationToken ct = default);
    //TODO add DownloadAsync for get files from storage
}