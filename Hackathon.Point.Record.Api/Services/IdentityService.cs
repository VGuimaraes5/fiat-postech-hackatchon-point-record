using System.Security.Claims;
using Hackathon.Point.Record.Api.Domain.Interfaces.Services;
using System.Text.Json;

namespace Hackathon.Point.Record.Api.Services;

public class IdentityService : IIdentityService
{
    private readonly IHttpContextAccessor _context;
    private readonly ILogger<IdentityService> _logger;

    public IdentityService(IHttpContextAccessor context, ILogger<IdentityService> logger)
    {
        _logger = logger;
        _context = context;
    }

    public string GetUserIdentification()
    {
        var identification = _context.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        _logger.LogWarning(identification);

        if (string.IsNullOrEmpty(identification)) throw new InvalidDataException("User identification not found!");

        return identification;
    }
}