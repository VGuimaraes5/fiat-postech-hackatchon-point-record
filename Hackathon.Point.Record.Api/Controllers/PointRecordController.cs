using Hackathon.Point.Record.Api.Domain.Interfaces.Services;
using Hackathon.Point.Record.Api.Domain.Models;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Point.Record.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PointRecordController : ControllerBase
{
    private readonly IIdentityService _identityService;
    private readonly IPublishEndpoint _publisher;

    public PointRecordController(IIdentityService identityService, IPublishEndpoint publisher)
    {
        _identityService = identityService;
        _publisher = publisher;
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        try
        {
            var model = new CreatePointRecordModel
            {
                RegisterDate = DateTime.Now,
                UserIdentification = _identityService.GetUserIdentification()
            };

            await _publisher.Publish(model);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
