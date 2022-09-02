using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SENSORLAB.Web.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient("sensorWebApi", httpClient =>
{
    httpClient.BaseAddress = new Uri("http://localhost:8081/api/");
});
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<Sensor1Services>();
builder.Services.AddSingleton<Sensor2Services>();
builder.Services.AddSingleton<Sensor3Services>();
builder.Services.AddHttpClient();
builder.Services.AddTelerikBlazor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
