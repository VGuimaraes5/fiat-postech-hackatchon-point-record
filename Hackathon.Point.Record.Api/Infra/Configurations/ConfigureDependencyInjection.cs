using Hackathon.Point.Record.Api.Domain.Interfaces.Services;
using Hackathon.Point.Record.Api.Domain.Interfaces.Repositories;
using Hackathon.Point.Record.Api.Services;
using Hackathon.Point.Record.Api.Infra.Repositories;

namespace Hackathon.Point.Record.Api.Infra.Configurations;

public static class ConfigureDependencyInjection
{
    public static IServiceCollection ConfigDependencyInjection(this IServiceCollection services)
    {
        services.AddTransient<IIdentityService, IdentityService>();
        services.AddTransient<IPointRecordService, PointRecordService>();

        services.AddTransient<IPointRecordRepository, PointRecordRepository>();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        return services;
    }
}