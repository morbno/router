using Serilog;
using TestEntryPoint;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

IHost host = Host.CreateDefaultBuilder(args)
    .UseSerilog()
    .ConfigureServices(services => { services.AddHostedService<EntryPoint>(); })
    .Build();

host.Run();