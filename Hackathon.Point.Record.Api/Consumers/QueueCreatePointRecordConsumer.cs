using Hackathon.Point.Record.Api.Domain.Interfaces.Services;
using Hackathon.Point.Record.Api.Domain.Models;
using MassTransit;

namespace Hackathon.Point.Record.Api.Consumers;

public class QueueCreatePointRecordConsumer : IConsumer<CreatePointRecordModel>
{
    private readonly IPointRecordService _pointRecordService;
    private readonly ILogger<QueueCreatePointRecordConsumer> _logger;

    public QueueCreatePointRecordConsumer(
        IPointRecordService pointRecordService,
        ILogger<QueueCreatePointRecordConsumer> logger)
    {
        _pointRecordService = pointRecordService;
        _logger = logger;
    }

    public async Task Consume(ConsumeContext<CreatePointRecordModel> context)
    {
        try
        {
            await _pointRecordService.CreateAsync(context.Message);

            _logger.LogInformation("Register with success!");
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex.Message}");
        }
    }
}