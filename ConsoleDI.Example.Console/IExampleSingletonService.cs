using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example.Console;

public interface IExampleSingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}
