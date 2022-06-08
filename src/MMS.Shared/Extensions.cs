using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MMS.Shared.Exceptions;
using MMS.Shared.Services;

namespace MMS.Shared;

public static class Extensions
{
    public static IServiceCollection AddShared(this IServiceCollection services)
    {
        services.AddHostedService<AppInitializer>();
        services.AddScoped<ExceptionMiddleware>();
        return services;
    }

    public static IApplicationBuilder UseShared(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
        return app;
    }
}
