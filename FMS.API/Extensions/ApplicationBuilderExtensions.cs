using FMS.API.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FMS.API.Extensions;

public static class ApplicationBuilderExtensions
{
    public static WebApplication ApplyMigrations(this WebApplication app)
    {
        using var scoped = app.Services.CreateScope();
        var db = scoped
            .ServiceProvider
            .GetRequiredService<FmsDbContext>();
        db.Database.Migrate();
        return app;
    }
}