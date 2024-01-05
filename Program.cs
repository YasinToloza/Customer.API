using Customer.API.Data;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Customer.API.Repositories;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configurando EF Core con SQL Server
var connectionString = builder.Configuration.GetConnectionString("CustomerDB");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

//Configurar Inyeccion de dependencia
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();

//Configurar MediatR
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
