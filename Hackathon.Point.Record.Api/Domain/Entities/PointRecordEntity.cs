using Hackathon.Point.Record.Api.Domain.Entities.Base;
using Hackathon.Point.Record.Api.Domain.Enums;

namespace Hackathon.Point.Record.Api.Domain.Entities;

public class PointRecordEntity : BaseEntity
{
    public required DateTime RegisterDate { get; set; }
    public required string UserIdentification { get; set; }
    public PointRecordTypeEnum Type { get; set; }

    public PointRecordTypeEnum SetType(PointRecordEntity? lastRecord)
    {
        if (lastRecord == null) return PointRecordTypeEnum.Entry;
        if (lastRecord.Type == PointRecordTypeEnum.Entry) return PointRecordTypeEnum.Exit;
        return PointRecordTypeEnum.Entry;
    }
}