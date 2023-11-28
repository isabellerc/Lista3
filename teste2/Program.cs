using GestaoDeProduto.Data.Repositories;
using GestaoDeProduto.Domain.Interfaces;
//using GestaoProjeto.Application.Interfaces;
//using GestaoProjeto.Application.Services;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
//using GestaoProjeto.Application.AutoMapper;
using GestaoDeProduto.Data.Providers.MongoDb.Configuration;
using GestaoDeProduto.Data.Providers.MongoDb.Interfaces;
using Microsoft.Extensions.Options;
using GestaoDeProduto.Data.Providers.MongoDb.Collections;
using GestaoDeProduto.Data.Providers.MongoDb;
using GestaoDeProduto.Data.AutoMapper;
using GestaoDeProduto.Data.AutoMapper;
using GestaoDeProduto.Data.Providers.MongoDb.Configuration;
using GestaoDeProduto.Data.Providers.MongoDb.Interfaces;
using GestaoDeProduto.Data.Providers;
using GestaoDeProduto.Data.Repositories;
using GestaoDeProduto.Domain.Interfaces;
using LojaH1.Catalogo.Application.AutoMapper;
using LojaH1.Catalogo.Application.Interface;
using LojaH1.Catalogo.Application.Services;
using LojaH1.Catalogo.Infra.EmailService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

builder.Services.AddAutoMapper(typeof(DomainToCollection), typeof(CollectionToDomain));
builder.Services.AddScoped<EmailService>();


builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IProdutoService, ProdutoService>();

builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IFornecedorService, FornecedorService>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
       serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

builder.Services.AddScoped(typeof(IMongoRepository<>), typeof(MongoRepository<>));



builder.Services.Configure<EmailConfig>(builder.Configuration.GetSection("EmailConfig"));



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
