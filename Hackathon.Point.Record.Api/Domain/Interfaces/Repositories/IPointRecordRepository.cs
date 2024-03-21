using Hackathon.Point.Record.Api.Domain.Entities;

namespace Hackathon.Point.Record.Api.Domain.Interfaces.Repositories;

public interface IPointRecordRepository
{
    Task CreateAsync(PointRecordEntity entity);
    Task<PointRecordEntity?> GetLastByUserAsync(string userIdentification, DateTime date);
}