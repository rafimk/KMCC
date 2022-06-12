using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MMS.Domain.Repositories.Memberships;
using MMS.Domain.Repositories.Memberships.Professions;
using MMS.Domain.Repositories.Memberships.Qualifications;
using MMS.Domain.Repositories.Nationalities;
using MMS.Domain.Repositories.Users;
using MMS.Infrastructure.EF.Contexts;
using MMS.Infrastructure.EF.Options;
using MMS.Infrastructure.EF.Repositories.Memberships;
using MMS.Infrastructure.EF.Repositories.Memberships.Professions;
using MMS.Infrastructure.EF.Repositories.Memberships.Qualifications;
using MMS.Infrastructure.EF.Repositories.Nationalities;
using MMS.Infrastructure.EF.Repositories.Users;
using MMS.Shared.Options;

namespace MMS.Infrastructure.EF;

internal static class Extensions
{
    public static IServiceCollection AddPostgres(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IAreaRepository, PostgresAreaRepository>();
        services.AddScoped<IDistrictRepository, PostgresDistrictRepository>();
        services.AddScoped<IMandalamRepository, PostgresMandalamRepository>();
        services.AddScoped<IPanchayatRepository, PostgresPanchayatRepository>();
        services.AddScoped<IStateRepository, PostgresStateRepository>();
        
        services.AddScoped<IUserRepository, PostgresUserRepository>();
        
        services.AddScoped<IProfessionRepository, PostgresProfessionRepository>();
        services.AddScoped<IQualificationRepository, PostgresQualificationRepository>();
        
        services.AddScoped<IMembershipPeriodRepository, PostgresMembershipPeriodRepository>();
        services.AddScoped<IMembershipRepository, PostgresMembershipRepository>();

        var options = configuration.GetOptions<PostgresOptions>("Postgres");
        services.AddDbContext<MMSDbContext>(ctx => 
            ctx.UseNpgsql(options.ConnectionString));
        return services;
    }
}