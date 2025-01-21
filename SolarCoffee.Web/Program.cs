using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data;

var builder = WebApplication.CreateBuilder(args);

// Configuración de servicios (antes estaba en Startup.cs)
builder.Services.AddControllers();

// Configuración de la base de datos
builder.Services.AddDbContext<SolarDbContext>(options =>
{
    options.EnableDetailedErrors();
    options.UseNpgsql(builder.Configuration.GetConnectionString("solar.dev"));
});

// Agregar servicios como Identity, Swagger, etc.
var app = builder.Build();

// Configuración de la canalización de solicitud (antes en Configure)
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

// Configuración de los endpoints
app.MapControllers();

app.Run();
