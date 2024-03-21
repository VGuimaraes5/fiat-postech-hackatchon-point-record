using Hackathon.Point.Record.Api.Domain.Entities;
using Hackathon.Point.Record.Api.Infra.Mappings;
using Hackathon.Point.Record.Api.Infra.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Hackathon.Point.Record.Api.Infra.Context;

public class DataContext : DbContext
{
    public DbSet<PointRecordEntity>? PointRecord { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PointRecordMapping());

        PointRecordSeed.Seed(modelBuilder);
    }
}
