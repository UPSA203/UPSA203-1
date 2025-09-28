using Microsoft.EntityFrameworkCore;
using UPSA203API.Data;

var builder = WebApplication.CreateBuilder(args);

// ===========================
// Servicios
// ===========================

// Agregar controladores
builder.Services.AddControllers();

// Configurar EF Core con SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurar Swagger
builder.Services.AddEndpointsApiExplorer(); // Necesario para Swagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ===========================
// Middleware
// ===========================

// Habilitar Swagger siempre (puedes quitar el if para entornos de producción si quieres)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "UPSA203API v1");
});

// HTTPS
app.UseHttpsRedirection();

// Autorización
app.UseAuthorization();

// Mapear controladores
app.MapControllers();

app.Run();