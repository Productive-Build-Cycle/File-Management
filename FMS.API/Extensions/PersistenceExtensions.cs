using FMS.API.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FMS.API.Extensions;

public static class PersistenceExtensions
{
  public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration config)
  {
    services.AddDbContext<FmsDbContext>(opt =>
      opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
    return services;
  }  
}