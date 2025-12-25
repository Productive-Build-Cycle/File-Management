using FMS.API.Extensions;
using FMS.API.Persistence.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPersistence(builder.Configuration);



var app = builder.Build();

if (app.Environment.IsDevelopment()) app.ApplyMigrations();



app.Run();