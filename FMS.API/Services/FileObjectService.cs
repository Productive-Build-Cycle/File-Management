using FMS.API.DTOs;
using FMS.API.Entities;
using FMS.API.Persistence.Repositories.Interfaces;
using FMS.API.Services.Interfaces;
using Mapster;

namespace FMS.API.Services;

public class FileObjectService(
    IFileObjectRepository fileObjectRepository,
    IStorageService storageService
    )
    : IFileObjectService
{
    private readonly IFileObjectRepository _fileObjectRepository = fileObjectRepository;
    private readonly IStorageService _storageService = storageService;

    /// <summary>
    /// Upload a new file service
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <returns></returns>

    public async Task<FileUploadResult> UploadFileAsync(FileUploadRequest request, CancellationToken ct = default)
    {
        var file = request.File;
        var bucketName = "default"; //=> it should implement from real config
        
        var storedFileName = await _storageService.UploadAsync(file, bucketName, ct);

        var fileEntity = new FileObject
        (
            originalFileName: file.FileName,
            storedFileName: storedFileName,
            contentType: file.ContentType,
            size: file.Length,
            bucketName: bucketName
        );
        
        await _fileObjectRepository.AddAsync(fileEntity, ct);
        return fileEntity.Adapt<FileUploadResult>();

    }
    /// <summary>
    /// Get all files
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<IReadOnlyList<FileObjectDto>> GetAllFilesAsync(CancellationToken ct = default)
    {
        var files = await _fileObjectRepository.GetAllAsync(ct);
        return files.Adapt<IReadOnlyList<FileObjectDto>>();
    }
    public Task<FileObjectDto?> GetFileByIdAsync(int id, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }


    public Task DeleteFileByIdAsync(int id, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}