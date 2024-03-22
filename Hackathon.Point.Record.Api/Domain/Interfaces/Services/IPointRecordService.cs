using Hackathon.Point.Record.Api.Domain.Models;

namespace Hackathon.Point.Record.Api.Domain.Interfaces.Services;

public interface IPointRecordService
{
    Task CreateAsync(CreatePointRecordModel model);
}