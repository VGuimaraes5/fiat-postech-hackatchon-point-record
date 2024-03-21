using Hackathon.Point.Record.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hackathon.Point.Record.Api.Infra.Mappings;

public class PointRecordMapping : IEntityTypeConfiguration<PointRecordEntity>
{
    public void Configure(EntityTypeBuilder<PointRecordEntity> builder)
    {
        builder
            .ToTable("tb_point_record");

        builder.HasKey(p => p.Id);

        builder.HasIndex(p => p.UserIdentification);
    }
}