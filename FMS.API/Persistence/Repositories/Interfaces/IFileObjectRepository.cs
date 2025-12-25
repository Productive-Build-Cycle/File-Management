using FMS.API.Entities;

namespace FMS.API.Persistence.Repositories.Interfaces;

public interface IFileObjectRepository
{
    Task AddAsync(FileObject fileObject, CancellationToken ct = default);
    Task<IReadOnlyList<FileObject>> GetAllAsync(CancellationToken ct = default);
    //TODO GetByIdAsync
    //TODO UpdateAsync
    //TODO SoftDeleteAsync
    //TODO SoftDeleteByRangeAsync
    //TODO RestoreAsync
}