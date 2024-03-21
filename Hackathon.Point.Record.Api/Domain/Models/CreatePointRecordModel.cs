namespace Hackathon.Point.Record.Api.Domain.Models;

public class CreatePointRecordModel
{
    public required DateTime RegisterDate { get; set; }
    public required string UserIdentification { get; set; }
}