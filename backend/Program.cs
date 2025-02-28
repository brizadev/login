using backend.Data;
using backend.Extensions;
using backend.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Validação da string de conexão
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
if (string.IsNullOrEmpty(connectionString))
{
    throw new InvalidOperationException("A string de conexão do banco de dados não foi configurada.");
}

// Configuração do Entity Framework
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
);

// Configuração do JWT
builder.Services.AddJwtAuthentication(builder.Configuration); // Método de extensão

// Configuração de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        // Caso for usar local especifico remover = policy.AllowAnyOrigin()
              policy.AllowAnyOrigin()
        // Descomente esse caso for usar local especifico = policy.WithOrigins("http://seu.local.especifico/brizollaAPI/API.html?") 
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Configuração de Logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração dos serviços
builder.Services.AddScoped<UsuarioService>();

//  Configuração correta do Kestrel para evitar o aviso
builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(5070); // HTTP
    serverOptions.ListenAnyIP(7178, listenOptions => listenOptions.UseHttps()); // HTTPS
});

var app = builder.Build();

// Configuração do pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigin");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// Middleware de tratamento de erros
app.Use(async (context, next) =>
{
    try
    {
        await next();
    }
    catch (Exception ex)
    {
        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
        await context.Response.WriteAsJsonAsync(new { error = $"Ocorreu um erro interno no servidor: {ex.Message}" });
    }
});

app.Run();
