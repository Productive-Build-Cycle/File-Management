using FMS.API.Persistence.Repositories.Interfaces;
using FMS.API.Services.Interfaces;

namespace FMS.API.Services;

public class FileObjectService(IFileObjectRepository fileObjectRepository)
    : IFileObjectService
{
    private readonly IFileObjectRepository _fileObjectRepository = fileObjectRepository;
    
    
}