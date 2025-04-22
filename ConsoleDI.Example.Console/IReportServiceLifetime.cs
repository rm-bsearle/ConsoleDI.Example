using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI.Example.Console;

public interface IReportServiceLifetime
{
    Guid Id { get; }

    ServiceLifetime Lifetime { get; }
}
