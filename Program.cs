using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Configuração do banco de dados
builder.Services.AddDbContext<OrganizadorContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("ConexaoPadrao"),
    new MySqlServerVersion(new Version(8, 0, 21))));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
