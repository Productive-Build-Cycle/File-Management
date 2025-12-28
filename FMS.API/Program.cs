using FMS.API.Extensions;
using FMS.API.Persistence.Repositories;
using FMS.API.Persistence.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IFileObjectRepository, FileObjectObjectRepository>();

builder.Services.AddControllers();
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.ApplyMigrations();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();



app.Run();