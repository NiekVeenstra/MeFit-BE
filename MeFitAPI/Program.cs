using MeFitAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Retrieve database credentials from environment variables
string host = Environment.GetEnvironmentVariable("DB_HOST");
string database = Environment.GetEnvironmentVariable("DB_DATABASE");
string username = Environment.GetEnvironmentVariable("DB_USERNAME");
string password = Environment.GetEnvironmentVariable("DB_PASSWORD");
string port = Environment.GetEnvironmentVariable("DB_PORT");

// Replace placeholders in appsettings.json with actual values
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    .Replace("{DB_HOST}", host)
    .Replace("{DB_DATABASE}", database)
    .Replace("{DB_USERNAME}", username)
    .Replace("{DB_PASSWORD}", password)
    .Replace("{DB_PORT}", port);

builder.Services.AddDbContext<MeFitDbContext>(options =>
                options.UseNpgsql(connectionString));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
