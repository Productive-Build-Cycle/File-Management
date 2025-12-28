using FMS.API.Entities;
using FMS.API.Persistence.Context;
using FMS.API.Persistence.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FMS.API.Persistence.Repositories;

public class FileObjectObjectRepository(FmsDbContext ctx) : IFileObjectRepository
{
    private readonly FmsDbContext _ctx = ctx;
    
    public async Task AddAsync(FileObject fileObject, CancellationToken ct)
    {
        await _ctx.FileObjects.AddAsync(fileObject, ct);
        await _ctx.SaveChangesAsync(ct);
    }

    public async Task<IReadOnlyList<FileObject>> GetAllAsync(CancellationToken ct = default)
    {
        return  await _ctx.FileObjects
            .Where(x => !x.IsDeleted)
            .OrderByDescending(x => x.CreatedAt)
            .ToListAsync(ct);
    }
}