using Microsoft.EntityFrameworkCore;
using Mission10_Elizalde.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<BowlingDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BowlingConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Allowing CORS for the React app to access the API
app.UseCors(x => x.WithOrigins("http://localhost:2001"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
