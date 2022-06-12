using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MMS.Application;
using MMS.Infrastructure;
using MMS.Shared;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddShared();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers();
            
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo {Title = "MMS.Api", Version = "v1"});
});

var app = builder.Build();
app.UseShared();

app.MapGet("/", () => "Hello World!");

app.Run();