using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices(
    services => {
        services.AddHostedService<Worker>();
        services.AddScoped<IMessageWriter, MessageWriter2>();
        services.AddScoped<IMessageWriter, MessageWriter>();
        services.AddScoped<IExample, Example>();
        services.AddScoped<string>(_ => "foo");
        services.AddScoped<Dummy>();
    }
);

using var host = builder.Build();
host.Run();
