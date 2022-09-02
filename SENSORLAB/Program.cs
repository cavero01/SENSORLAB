using Microsoft.AspNetCore.OData;
using SENSORLAB.Brokers.Storages;
using SENSORLAB.Models;
using SENSORLAB.Services.Clientes;
using SENSORLAB.Services.Sensors;
using SENSORLAB.Services.Clientesensors;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<StorageBroker>();
builder.Services.AddControllers();
builder.Services.AddScoped<IStorageBroker, StorageBroker>();
builder.Services.AddControllers().AddOData(options => options.Select().Filter().OrderBy());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<ISensorService, SensorService>();
builder.Services.AddTransient<IClientesensorService, ClientesensorService>();

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
