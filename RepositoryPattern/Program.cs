using Microsoft.EntityFrameworkCore;
using RepositoryPattern._2___Domain.Concreta;
using RepositoryPattern._2___Domain.Interface;
using RepositoryPattern.Context;
using RepositoryPattern.Logging;
using RepositoryPattern.Middlewares;
using RepositoryPattern.Repository;
using RepositoryPattern.UnitOfWork;
using System;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. tudo isso será instanciado na  aplicação

builder.Services.AddControllers();

//Configuration Json Serialize
builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ILogin, LoginDomain>();
builder.Services.AddScoped<IMesGasto, MesGastoDomain>();
builder.Services.AddScoped<IGasto, GastoDomain>();
builder.Services.AddScoped<IUsuario, UsuarioDomain>();
builder.Services.AddScoped<IReceita, ReceitaDomain>();
builder.Services.AddScoped<IReceitaMesGasto, ReceitaMesGastoDomain>();
builder.Services.AddScoped<IBanco, BancoDomain>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Configurando conexão com banco de dados
string mySqlConnection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(
        mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)
    ));

//Configuration Logging
builder.Logging.AddProvider(new CustomLoggerProvider(new CustomLoggerProviderConfiguration
{
    LogLevel = LogLevel.Information,
}));


//Cada app.Use... ou app.Map... adiciona um middleware ao pipeline.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.ConfigureExceptionHandler();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
