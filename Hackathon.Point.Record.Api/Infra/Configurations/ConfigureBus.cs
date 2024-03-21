using Hackathon.Point.Record.Api.Consumers;
using MassTransit;

namespace Hackathon.Point.Record.Api.Infra.Configurations;

public static class ConfigureBus
{
    public static IServiceCollection ConfigBus(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMassTransit(config =>
        {
            config.AddConsumer<QueueCreatePointRecordConsumer>();

            config.UsingRabbitMq((ctx, busConfigurator) =>
            {
                busConfigurator.Host(configuration.GetConnectionString("RabbitMQ"));
                busConfigurator.ConfigureEndpoints(ctx);
            });
        });

        return services;
    }
}
