using Hackathon.Point.Record.Api.Domain.Entities;
using Hackathon.Point.Record.Api.Domain.Interfaces.Repositories;
using Hackathon.Point.Record.Api.Domain.Interfaces.Services;
using Hackathon.Point.Record.Api.Domain.Models;
using Hackathon.Reports.Api.Domain.Models;
using MassTransit;

namespace Hackathon.Point.Record.Api.Services;

public class PointRecordService : IPointRecordService
{
    private readonly IPointRecordRepository _pointRecordRepository;
    private readonly IPublishEndpoint _publisher;

    public PointRecordService(IPointRecordRepository pointRecordRepository, IPublishEndpoint publisher)
    {
        _pointRecordRepository = pointRecordRepository;
        _publisher = publisher;
    }

    public async Task CreateAsync(CreatePointRecordModel model)
    {
        try
        {
            var lastPointRecord = await _pointRecordRepository.GetLastByUserAsync(model.UserIdentification, model.RegisterDate);

            var entity = new PointRecordEntity
            {
                RegisterDate = model.RegisterDate,
                UserIdentification = model.UserIdentification,
            };

            entity.SetType(lastPointRecord);

            await _pointRecordRepository.CreateAsync(entity);

            await _publisher.Publish(new CreatePointRecordEvent
            {
                RegisterDate = entity.RegisterDate,
                UserIdentification = entity.UserIdentification,
                Type = entity.Type
            });
        }
        catch (Exception ex)
        {
            throw new Exception($"Error: {ex.Message}");
        }
    }
}