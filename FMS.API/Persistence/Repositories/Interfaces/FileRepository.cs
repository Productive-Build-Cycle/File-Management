using FMS.API.Entities;

namespace FMS.API.Persistence.Repositories.Interfaces;

public interface IFileRepository
{
    Task<FileObject> AddSync(IFormFile file);
    Task<IEnumerable<FileObject>> GetAllAsync();
    //TODO GetByIdAsync
    //TODO UpdateAsync
    //TODO SoftDeleteAsync
    //TODO SoftDeleteByRangeAsync
    //TODO RestoreAsync
}