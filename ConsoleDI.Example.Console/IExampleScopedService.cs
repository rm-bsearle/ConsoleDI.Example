using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example.Console;

public interface IExampleScopedService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
}
