using EfPelicula;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//Se agrega variable que captura la cedan de conexion de la BD
var conex = builder.Configuration.GetConnectionString("Default");
//creamos proceso para relacionar para inyectar la conexion y el dbcontex
builder.Services.AddDbContext<AppDbContext>(opciones => opciones.UseSqlServer(conex));

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
