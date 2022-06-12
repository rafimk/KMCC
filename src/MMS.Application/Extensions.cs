using Microsoft.Extensions.DependencyInjection;
using MMS.Domain.Policies.Users;
using MMS.Shared.Commands;

namespace MMS.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddCommands();

        services.Scan(b => b.FromAssemblies(typeof(IUserCreatePolicy).Assembly)
            .AddClasses(c => c.AssignableTo<IUserCreatePolicy>())
            .AsImplementedInterfaces()
            .WithSingletonLifetime());
            
        return services;
    }
}