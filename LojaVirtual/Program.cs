using LojaVirtual.Domain.Interfaces;
using LojaVirtual.Infrastructure.Models;
using LojaVirtual.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext Azure SQL
builder.Services.AddDbContext<LojaVirtualContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureConnection")));

// Repository
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
