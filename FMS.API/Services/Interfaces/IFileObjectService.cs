using FMS.API.DTOs;

namespace FMS.API.Services.Interfaces;

public interface IFileObjectService
{
    Task<FileUploadResult> UploadFileAsync(FileUploadRequest request, CancellationToken ct = default);
    Task<FileObjectDto?> GetFileByIdAsync(int id, CancellationToken ct = default);
    Task<IReadOnlyList<FileObjectDto>> GetAllFilesAsync(CancellationToken ct = default);
    Task DeleteFileByIdAsync(int id, CancellationToken ct = default);
}