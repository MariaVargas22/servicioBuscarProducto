using WebApiBuscarProductos;
using WebApiBuscarProductos.Application;
using WebApiBuscarProductos.Application.Contracts;
using WebApiBuscarProductos.Application.Service;
using WebApiBuscarProductos.Infraestructure.Configuration;
using WebApiBuscarProductos.Infraestructure.Repository;
using WebApiBuscarProductos.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


//carga de datos para base de datos 

builder.Services.Configure<DataBaseConfiguration>(builder.Configuration.GetSection("DatabaseConfiguration"));
builder.Services.RegisterMongoDependencies();



//dependecias 


//builder.Services.AddScoped<IBuscarProductosService, BuscarProductoService>();
//builder.Services.AddScoped<IBuscarRepository, ProductoRepository>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);


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
