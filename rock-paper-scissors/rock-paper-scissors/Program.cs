using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace rock_paper_scissors;

public static class Program
{
    public static async Task Main(string[] args)
    {
        using var host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
        {
            services.RegisterAppServices();
        }).Build();

        var runner = host.Services.GetRequiredService<IRunner>();

        await runner.RunAsync();
    }
}