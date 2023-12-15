using Microsoft.Extensions.DependencyInjection;
using rock_paper_scissors.Services;

namespace rock_paper_scissors;

public static class AppExtensions
{
    public static void RegisterAppServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IRunner, Runner>();
        serviceCollection.AddSingleton<IGameDecision, GameDecision>();
    }
}