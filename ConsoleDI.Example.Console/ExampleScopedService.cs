﻿namespace ConsoleDI.Example.Console;

internal sealed class ExampleScopedService : IExampleScopedService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}
