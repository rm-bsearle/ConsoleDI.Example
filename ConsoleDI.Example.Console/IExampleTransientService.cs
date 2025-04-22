using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example.Console;

public interface IExampleTransientService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
}
