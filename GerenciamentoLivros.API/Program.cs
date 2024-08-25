using GerenciamentoLivros.API.Data; // Namespace do AppDbContext
using GerenciamentoLivros.API.Repositories; // Namespace do LivroRepository
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados InMemory para o AppDbContext
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseInMemoryDatabase("LivrosDB"));

// Configuração dos repositórios
builder.Services.AddScoped<ILivroRepository, LivroRepository>();

// Configuração dos controladores
builder.Services.AddControllers();

// Configuração do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configuração do pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Aplicar a política de CORS
app.UseCors("AllowAll");

app.UseHttpsRedirection();

// Mapeamento dos controladores
app.MapControllers();

// Mapeamento do endpoint de exemplo (pode ser removido ou substituído)
app.MapGet("/weatherforecast", () =>
{
    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

// Record para o endpoint de exemplo (pode ser removido ou substituído)
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
