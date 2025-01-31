using InventoryAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Configuration
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
       .AddEnvironmentVariables();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
);


var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/", () => "¡Hola desde Minimal API en .NET 9!");


app.Run();
