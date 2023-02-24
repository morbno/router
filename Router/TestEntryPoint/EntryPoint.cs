namespace TestEntryPoint;

public class EntryPoint : BackgroundService
{
    private readonly ILogger<EntryPoint> _logger;

    public EntryPoint(ILogger<EntryPoint> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Hello world");
    }
} 