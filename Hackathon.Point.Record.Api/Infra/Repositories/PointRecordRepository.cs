using Hackathon.Point.Record.Api.Domain.Entities;
using Hackathon.Point.Record.Api.Domain.Interfaces.Repositories;
using Hackathon.Point.Record.Api.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Point.Record.Api.Infra.Repositories;

public class PointRecordRepository : IPointRecordRepository
{
    private readonly DataContext _context;
    private readonly DbSet<PointRecordEntity> _dbSet;

    public PointRecordRepository(DataContext context)
    {
        _context = context;
        _dbSet = context.Set<PointRecordEntity>();
    }

    public async Task CreateAsync(PointRecordEntity entity)
    {
        entity.CreatedAt = DateTime.Now;

        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<PointRecordEntity?> GetLastByUserAsync(string userIdentification, DateTime date)
    {
        var startDate = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        var endDate = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);

        return await _dbSet.OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync(
            x => x.UserIdentification == userIdentification &&
            x.RegisterDate >= startDate &&
            x.RegisterDate <= endDate);
    }
}